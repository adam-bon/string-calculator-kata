using System;
using System.Text.RegularExpressions;

namespace string_calculator_kata {
    public class StringCalculator {
        public StringCalculator() {
        }

        public int Add(String input)
        {

            string[] stringNumbers;
            char delimiter;


            // switch (input)
            // {
            //     case var someInput when new Regex(@"^$").IsMatch(someInput):
            //         return 0;
            //         break;
            //     case (input.StartsWith("//")):
            // }
            if (new Regex(@"^$").IsMatch(input))
                return 0;
            //split the input 
            else if (input.StartsWith("//"))
            {
                delimiter = input[2];
                stringNumbers = input.Split(delimiter, ',', '\n');

                return SumOfStringNumbers(stringNumbers);

            } else if (input.Contains(",") || input.Contains("\n")) 

            { 
          
             stringNumbers = input.Split(',', '\n');

             return SumOfStringNumbers(stringNumbers);
            }
            else
                return Int32.Parse(input);

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
        
    }
}
