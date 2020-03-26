using System;

namespace string_calculator_kata {
    public class StringCalculator {
        public StringCalculator() {
        }

        public int Calculate(String input)
        {

            string[] stringNumbers;
            char delimiter;
            if (input == "")
                return 0;
            //split the input 
            else if (input.Contains("//"))
            {
                delimiter = input[2];
                stringNumbers = input.Split(delimiter, ',', '\n');

                
                int sum = 0;
               
                foreach (string stringNum in stringNumbers) {

                    Int32.TryParse(stringNum, out int num);
                    sum += num;
                }

                return sum;

            } else if (input.Contains(",") || input.Contains("\n")) 

            { 
          
             stringNumbers = input.Split(',', '\n');

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
