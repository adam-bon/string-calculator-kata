using System.Linq;
using System;
using System.Text.RegularExpressions;

namespace string_calculator_kata {
    public class StringCalculator {
        public StringCalculator() {
        }

       private const string EmptyStringRegex = @"^$";
       private const string NegativeNumbersRegex = @"-\d+";
       private const string CustomDelimiterFlagRegex = @"^//";
       private const string CommaDelimiterRegex = @",";
       private const string SpaceDelimiterRegex = @"\n";
       private const string CustomDelimiterMultipleCharactersRegex = @"(?<=\[)(.*?)(?=\])";

        public int Add(String input)
        {
            
            
            string[] stringNumbers;

            switch (input)
            {
                case var someInput when new Regex(EmptyStringRegex).IsMatch(someInput):
                    return 0;

                case var someInput when new Regex(NegativeNumbersRegex).IsMatch(someInput):
                    MatchCollection negativeNumbers = Regex.Matches(input, @"-\d+");
                    throw new NegativeNumbersNotAllowedException($"Negatives not allowed: {String.Join(", ", negativeNumbers)}");

                case var someInput when new Regex(CustomDelimiterFlagRegex).IsMatch(someInput):
                    stringNumbers = SplitStringWithCustomDelimiter(input);
                    return SumOfStringNumbers(stringNumbers);

                case var someInput when new Regex(CommaDelimiterRegex).IsMatch(someInput) || new Regex(SpaceDelimiterRegex).IsMatch
                (someInput):
                    stringNumbers = input.Split(',', '\n');
                    return SumOfStringNumbers(stringNumbers);
                

                default:
                    return Int32.Parse(input);

            }
        }

        private int SumOfStringNumbers(string [] stringNumbers)
        {
            int sum = 0;
            foreach (string stringNum in stringNumbers) 
            {
                
                Int32.TryParse(stringNum, out int num);
                if (num < 1000)
                {
                    sum += num;
                }
                
            }

            return sum;
        }

        private string[] SplitStringWithCustomDelimiter(string input){
                //char delimiter = input[2];
                //[***]
                if(Regex.IsMatch(input,  CustomDelimiterMultipleCharactersRegex))
                {
                    int indexOfNumbers = 1;
                    Match delimiter = Regex.Match(input,  CustomDelimiterMultipleCharactersRegex); 
                    string[] splitInput = input.Split(',', '\n');
                    string[] stringNumbers = splitInput[indexOfNumbers].Split(delimiter.ToString(), StringSplitOptions.None);
                    return stringNumbers;
                } else
                {
                    int indexOfDelimiter = 2;
                    char delimiter = input[indexOfDelimiter];
                    return input.Split(delimiter, ',', '\n');
                }
        }     
    }
}
