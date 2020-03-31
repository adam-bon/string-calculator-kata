using System;
using Xunit;

namespace string_calculator_kata
{
    public class StringCalculatorTests
    {
        [Fact]
        public void StringCalculator_inputEmptyString_returnsZero() {

            const int expected = 0;
            int actual = new StringCalculator().Add("");
            Assert.Equal(expected, actual);
        }

        //discuss
        [Theory]
        [InlineData("1", 1)]
        [InlineData("3", 3)]
        [InlineData("4", 4)]
        [InlineData("5", 5)]


        public void StringCalculator_inputSingleNumberString_returnsNumberAsInt(string input, int expected) {

            StringCalculator stringCalculator = new StringCalculator();

            int actual = stringCalculator.Add(input);
            Assert.Equal(expected, actual);
            
        }

        [Theory]
        [InlineData("1,2", 3)]
        [InlineData("3,5", 8)]

        public void StringCalculator_inputTwoNumberString_returnsSum(string input, int expected) {

            StringCalculator stringCalculator = new StringCalculator();

            int actual = stringCalculator.Add(input);
            Assert.Equal(expected, actual);

        }

        [Theory]
        [InlineData("1,2,3", 6)]
        [InlineData("3,5,3,9", 20)]

        public void StringCalculator_inputAnyNumbersString_returnsSum(string input, int expected)
        {
            StringCalculator stringCalculator = new StringCalculator();

            int actual = stringCalculator.Add(input);
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("1,2\n3", 6)]
        [InlineData("3\n5\n3,9", 20)]

        public void StringCalculator_inputAnyNumbersStringWithLineBreaksOrCommas_returnsSum(string input, int expected)
        {
            StringCalculator stringCalculator = new StringCalculator();

            int actual = stringCalculator.Add(input);
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("//;\n1;2", 3)]
        public void StringCalculator_inputAnyNumbersAsStringWithCustomDelimiter_returnsSum(string input, int expected) {
            StringCalculator stringCalculator = new StringCalculator();

            int actual = stringCalculator.Add(input);
            Assert.Equal(expected, actual);
        }
        
        [Fact]
        // [InlineData("-1,2,-3", 2)]
        public void StringCalculator_inputNegativeNumbersThrowException() {
            StringCalculator stringCalculator = new StringCalculator();

            //int actual = stringCalculator.Add();
            Assert.Throws<NegativeNumbersNotAllowedException>(() => stringCalculator.Add("-1,2,-3"));
        }
    }
}
