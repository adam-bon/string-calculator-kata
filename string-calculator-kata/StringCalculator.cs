using System;
namespace string_calculator_kata {
    public class StringCalculator {
        public StringCalculator() {
        }

        public int Calculate(String input) {
            if (input == "")
                return 0;
            else
                return Int32.Parse(input);
        }
    }
}
