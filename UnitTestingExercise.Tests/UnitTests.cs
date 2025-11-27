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
        [InlineData(-3, 11, -17, -9)]
        public void AddTest(int firstAddend, int secondAddend, int thirdAddend, int expected)
        {
            //Start Step 3 here:

            //Arrange
            // create a Calculator object
            Calculator calculator = new Calculator();

            //Act
            // call the Add method that is located in the Calculator class
            // and store its result in a variable named actual
            int actual = calculator.Add(firstAddend, secondAddend, thirdAddend);

            //Assert
            //Assert.Equal(expected, actual);
            Assert.Equal(expected, actual);
            
        }

        [Theory]
        [InlineData(17, 13, 4)]//Add test data <-------
        [InlineData(13, 11, 2)]
        [InlineData(11, 7, 4)]
        [InlineData(7, 5, 2)]
        [InlineData(5, 3, 2)]
        [InlineData(3, 13, -10)]
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
        [InlineData(2,3,6)]//Add test data <-------
        [InlineData(3,5,15)]
        [InlineData(5,7,35)]
        [InlineData(7,11,77)]
        [InlineData(11,13,143)]
        [InlineData(-3,13,-39)]
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
        [InlineData(17, 3, 5, 2)]
        [InlineData(17, 13, 1, 4)]//Add test data <-------
        [InlineData(13, 11, 1, 2)]
        [InlineData(11, 7, 1, 4)]
        [InlineData(7, 5, 1, 2)]
        [InlineData(5, 3, 1, 2)]
        [InlineData(3, 2, 1, 1)]
        [InlineData(-3, 17, 0, -3)]
        [InlineData(0, -2, 0, 0)]
        [InlineData(2, -3, 0, 2)]
        [InlineData(-3, 5, 0, -3)]
        [InlineData(-5, -7, 0, -5)]
        [InlineData(7, -11, 0, 7)]
        [InlineData(-11, 13, 0, -11)]
        [InlineData(-13, -17, 0, -13)]
        [InlineData(-17, 3, -5, -2)]
        [InlineData(17, -3, -5, 2)]
        [InlineData(-17, -3, 5, -2)]
        public void DivideTest(int dividend, int divisor, int expectedQuotient, int expectedRemainder)
        {
            //Arrange
            Calculator calculator = new Calculator();

            //Act
            (int actualQuotient, int actualRemainder) = calculator.Divide(dividend, divisor);

            //Assert
            Assert.Equal(expectedQuotient, actualQuotient);
            Assert.Equal(expectedRemainder, actualRemainder);

        }

        [Fact]
        public void DivideByZeroTest()
        {
            // Arrange
            Calculator calculator = new Calculator();
            Random randomGenerator = new Random();
            int dividend = randomGenerator.Next();
            int divisor = 0;
            
            // Act
            Action actual = () => calculator.Divide(dividend, divisor);
            
            // Assert
            Assert.Throws<DivideByZeroException>(actual);
        }
    }
}
