using System;

namespace string_calculator_kata {
    public class StringCalculator {
        public StringCalculator() {
        }

        public int Calculate(String input)
        {

            string[] stringNumbers;
            string delimiter = "";
            if (input == "")
                return 0;
            //split the input 
            else if (input.Contains("//"))
            {
                delimiter = input[2].ToString();
                stringNumbers = input.Split(delimiter);

            }

            else if ()
            {
                int sum = 0;
                foreach (string stringNum in stringNumbers)
                {
                    sum += Int32.Parse(stringNum);
                }

                return sum;
            }
            else
                return Int32.Parse(input);

        }
    }
        
    }
}
