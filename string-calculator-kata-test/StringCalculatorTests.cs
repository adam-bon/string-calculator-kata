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

        [Fact]
        public void StringCalculator_inputSingleNumberString_returnsNumberAsInt() {

            const int expected = 1;
            int actual = new StringCalculator().Calculate("1");
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void StringCalculator_inputNumberThreeAsString_returnsTwoAsInt() {

            const int expected = 3;
            int actual = new StringCalculator().Calculate("3");
            Assert.Equal(expected, actual);
        }

    }
}
