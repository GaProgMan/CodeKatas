using System;
using src;
using Xunit;

namespace tests
{
    public class RomanNumeralGuardTests
    {
        [Theory]
        [InlineData(null)]
        [InlineData(default(string))]
        [InlineData("")]
        [InlineData(" ")]
        [InlineData("         ")]
        public void Should_Throw_ArgumentException_When_Input_EmptyOrNull(string input)
        {
            // Arrange
            var parser = new Parser();

            // Act
            var responseException = Record.Exception(() => parser.Parse(input));
            
            // Assert
            Assert.NotNull(responseException);
            Assert.IsAssignableFrom<ArgumentException>(responseException);
            Assert.NotEmpty(responseException.Message);
            Assert.Contains("input", responseException.Message);
            Assert.Contains("null or empty", responseException.Message);
        }

        [Theory]
        [InlineData("Jeff")]
        [InlineData("Jamie is a wally")]
        public void Should_Throw_ArgumentException_When_Input_Not_RomanNumeral(string input)
        {
            // Arrange
            var parser = new Parser();
            
            // Act
            var responseException = Record.Exception(() => parser.Parse(input));

            // Assert
            Assert.NotNull(responseException);
            Assert.IsAssignableFrom<ArgumentException>(responseException);
            Assert.NotEmpty(responseException.Message);
            Assert.Contains("input", responseException.Message);
            Assert.Contains("Roman Numeral", responseException.Message);
        }
    }
}