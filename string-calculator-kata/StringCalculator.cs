using System.Linq;
using System;
using System.Collections.Generic;
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
       private const string CustomDelimiterNumberOnEdge = @"(\[\d.*?\])|(\[.*\d\])"; 
       
        public int Add(String input)
        {   
            string[] stringNumbers;

            switch (input)
            {
                case var matchedInput when new Regex(EmptyStringRegex).IsMatch(matchedInput):
                    return 0;

                case var matchedInput when new Regex(NegativeNumbersRegex).IsMatch(matchedInput):
                    MatchCollection negativeNumbers = Regex.Matches(input, @"-\d+");
                    throw new NegativeNumbersNotAllowedException($"Negatives not allowed: {String.Join(", ", negativeNumbers)}");

                case var matchedInput when new Regex(CustomDelimiterFlagRegex).IsMatch(matchedInput):
                    stringNumbers = SplitStringWithCustomDelimiter(input);
                    return SumOfStringNumbers(stringNumbers);

                case var matchedInput when new Regex(CommaDelimiterRegex).IsMatch(matchedInput) || new Regex(SpaceDelimiterRegex).IsMatch
                (matchedInput):
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

                if(Regex.IsMatch(input,  CustomDelimiterNumberOnEdge))
                {
                    Match delimiterWithNumberOnEdge = Regex.Match(input, CustomDelimiterNumberOnEdge);
                    throw new NumbersCannotBeEdgeOfDelimiterException($"Number can't be on edge of delimiter: {delimiterWithNumberOnEdge.ToString()}");
                }

                if(Regex.IsMatch(input,  CustomDelimiterMultipleCharactersRegex))
                {
                    int indexOfNumbers = 1;
                    MatchCollection delimitersMatchCollection = Regex.Matches(input,  CustomDelimiterMultipleCharactersRegex);
                    string[] delimitersArray = delimitersMatchCollection.Select(m => m.Value).ToArray();
                    string[] splitInput = input.Split(',', '\n');
                    
                    string[] stringNumbersArray;
                    
                    stringNumbersArray = splitInput[indexOfNumbers].Split(delimitersArray, StringSplitOptions
                        .None);
                    
                    return stringNumbersArray;  
                    
                } else
                {
                    int indexOfDelimiter = 2;
                    char delimiter = input[indexOfDelimiter];
                    return input.Split(delimiter, ',', '\n');
                }
        }     
    }
}
