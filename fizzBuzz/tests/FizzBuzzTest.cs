using System;
using System.Collections.Generic;
using Xunit;

using src;

namespace tests
{
    public class FizzBuzzTest
    {
        private readonly FizzBuzz _fizzBuzz;
        public FizzBuzzTest()
        {
            //Arrange
            _fizzBuzz = new FizzBuzz();
        }

        [Theory]
        [InlineData(3)]
        [InlineData(6)]
        [InlineData(9)]
        [InlineData(27)]
        public void GivenMultipleOf3ReturnsFizz(int value)
        {
            //Act
            var response = _fizzBuzz.Evaluate(value);

            //Assert
            Assert.Equal("Fizz", response);
        }

        [Theory]
        [InlineData(5)]
        [InlineData(10)]
        [InlineData(20)]
        public void GivenMultipleOf5ReturnsBuzz(int value)
        {
            //Act
            var response = _fizzBuzz.Evaluate(value);

            //Assert
            Assert.Equal("Buzz", response);
        }

        [Theory]
        [InlineData(15)]
        [InlineData(30)]
        [InlineData(60)]
        public void GivenMultipleOf3And5ReturnsFizzBuzz(int value)
        {
            //Act
            var response = _fizzBuzz.Evaluate(value);

            //Assert
            Assert.Equal("FizzBuzz", response);
        }

        [Theory]
        [InlineData(1)]
        [InlineData(7)]
        [InlineData(83)]
        public void GivenNonMultipleOf3_5_Or15ReturnNumber(int value)
        {
            //Act
            var response = _fizzBuzz.Evaluate(value);

            //Assert
            Assert.Equal(value.ToString(), response);
        }
    }
}
