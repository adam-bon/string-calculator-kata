using System;
using Xunit;

namespace string_calculator_kata
{
    public class UnitTest1
    {
        [Fact]
        public void StringCalculator_inputEmptyString_returnsZero() {

            const int expected = 0;
            int actual = new StringCalculator().Calculate("");
            Assert.Equal(expected, actual);
        }

        //discuss
        [Theory]
        [InlineData("1", 1)]
        [InlineData("3", 3)]
        [InlineData("4", 4)]
        [InlineData("5", 5)]


        public void StringCalculator_inputSingleNumberString_returnsNumberAsInt(String input, int expected) {

            StringCalculator stringCalculator = new StringCalculator();

            int actual = stringCalculator.Calculate(input);
            Assert.Equal(expected, actual);
            
        }

        [Theory]
        [InlineData("1,2", 3)]
        [InlineData("3,5", 8)]

        public void StringCalculator_inputTwoNumberString_returnsSum(String input, int expected) {

            StringCalculator stringCalculator = new StringCalculator();

            int actual = stringCalculator.Calculate(input);
            Assert.Equal(expected, actual);

        }

    }
}
