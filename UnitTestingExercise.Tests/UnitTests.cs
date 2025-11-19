using System;
using Xunit;

namespace UnitTestingExercise.Tests
{
    public class UnitTests
    {
        [Theory]
        [InlineData(2, 3, 5, 10)] //Add test data <-------
        [InlineData(3, 5, 7, 15)]
        [InlineData(5, 7, 11, 23)]
        [InlineData(7, 11, 13, 31)]
        [InlineData(11, 13, 17, 41)]
        public void AddTest(int num1, int num2, int num3, int expected)
        {
            //Start Step 3 here:

            //Arrange
            // create a Calculator object
            Calculator calculator = new Calculator();

            //Act
            // call the Add method that is located in the Calculator class
            // and store its result in a variable named actual
            int actual = calculator.Add(num1, num2, num3);

            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(17, 13, 4)] //Add test data <-------
        [InlineData(13, 11, 2)]
        [InlineData(11, 7, 4)]
        [InlineData(7, 5, 2)]
        [InlineData(5, 3, 2)]
        public void SubtractTest(int minuend, int subtrahend, int expected)
        {
            //Start Step 5 here:

            //Arrange
            Calculator calculator = new Calculator();

            //Act
            int actual = calculator.Subtract(minuend, subtrahend);

            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(2, 3, 6)] //Add test data <-------
        [InlineData(3, 5, 15)]
        [InlineData(5, 7, 35)]
        [InlineData(7, 11, 77)]
        [InlineData(11, 13, 143)]
        public void MultiplyTest(int firstFactor, int secondFactor, int expected)
        {
            //Start Step 7 here:

            //Arrange
            Calculator calculator = new Calculator();

            //Act
            int actual = calculator.Multiply(firstFactor, secondFactor);

            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(17, 13, 1.307692)] //Add test data <-------
        [InlineData(13, 11, 1.18)]
        [InlineData(11, 7, 1.571428)]
        [InlineData(7, 5, 1.4)]
        [InlineData(5, 3, 1.6)]
        public void DivideTest(int dividend, int divisor, decimal expected)
        {
            //Arrange
            Calculator calculator = new Calculator();

            //Act
            decimal actual = calculator.Divide(dividend, divisor);

            //Assert
            Assert.Equal(expected, actual);
        }
    }
}
