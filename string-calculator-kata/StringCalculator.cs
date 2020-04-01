using System;
using System.Text.RegularExpressions;

namespace string_calculator_kata {
    public class StringCalculator {
        public StringCalculator() {
        }

        public int Add(String input)
        {
            
            
            string[] stringNumbers;

            switch (input)
            {
                case var someInput when new Regex(@"^$").IsMatch(someInput):
                    return 0;

                case var someInput when new Regex(@"-[0-9]").IsMatch(someInput):
                throw new NegativeNumbersNotAllowedException("Negatives not allowed");
                //return 0;

                case var someInput when new Regex(@"^//").IsMatch(someInput):
                    stringNumbers = SplitStringWithCustomDelimiter(input);
                    return SumOfStringNumbers(stringNumbers);

                case var someInput when new Regex(@",").IsMatch(someInput) || new Regex(@"\n").IsMatch(someInput):
                    stringNumbers = input.Split(',', '\n');
                    return SumOfStringNumbers(stringNumbers);

                default:
                    return Int32.Parse(input);

            }
        }

        private int SumOfStringNumbers(string [] stringNumbers)
        {
            int sum = 0;
            foreach (string stringNum in stringNumbers) {
                Int32.TryParse(stringNum, out int num);
                sum += num;
            }

            return sum;
        }

        private string[] SplitStringWithCustomDelimiter(string input){
                char delimiter = input[2];
                return input.Split(delimiter, ',', '\n');
        }
        
    }
}
