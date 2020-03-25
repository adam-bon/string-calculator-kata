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
        [Fact]
        public void StringCalculator_inputSingleNumberString_returnsNumberAsInt() {

            StringCalculator stringCalculator = new StringCalculator();

            int expected = 1;
            int actual = stringCalculator.Calculate("1");
            Assert.Equal(expected, actual);

            expected = 3;
            actual = stringCalculator.Calculate("3");
            Assert.Equal(expected, actual);
            
        }

        [Fact]
        public void StringCalculator_inputTwoNumberString_returnsSum() {

            StringCalculator stringCalculator = new StringCalculator();

            int expected = 3;
            int actual = stringCalculator.Calculate("1,2");
            Assert.Equal(expected, actual);

            expected = 8;
            actual = stringCalculator.Calculate("3,5");
            Assert.Equal(expected, actual);

        }

    }
}
