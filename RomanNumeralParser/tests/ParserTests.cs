using src;
using Xunit;

namespace tests
{
    public class ParserTests
    {
        [Fact]
        public void Should_Exist()
        {
            // Arrange
            var parser = new Parser();
            // Act
            // Assert
            Assert.NotNull(parser);
        }

        [Fact]
        public void Parse_ShouldTake_String_Return_Int()
        {
            // Arrange
            var parser = new Parser();
            var input = "III"; // 3 in Roman Numerals
            
            // Act
            var response = parser.Parse(input);

            // Assert
            Assert.NotNull(response);
            Assert.IsType<int>(response);
        }
        
        [Theory]
        [InlineData("III", 3)]
        [InlineData("I", 1)]
        [InlineData("IV", 4)]
        [InlineData("MCMLXXXVI", 1986)]
        [InlineData("MMXX", 2020)]
        [InlineData("MDC", 1600)]
        public void Parse_ShouldTake_String_Return_CorrectIntValue(string input, int targetOutput)
        {
            // Arrange
            var parser = new Parser();
            
            // Act
            var response = parser.Parse(input);

            // Assert
            Assert.NotNull(response);
            Assert.IsType<int>(response);
            Assert.Equal(targetOutput, response);
        }
    }
}
