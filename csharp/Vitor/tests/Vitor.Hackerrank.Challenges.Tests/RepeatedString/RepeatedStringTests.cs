using FluentAssertions;
using Vitor.Hackerrank.Challenges.RepeatedString;
using Xunit;

namespace Vitor.Hackerrank.Challenges.Tests.RepeatedString
{
    public sealed class RepeatedStringTests
    {
        [Theory]
        [InlineData("aba", 10, 7)]
        public void Should_Return_The_Frequecy_Of_Letter_A_In_Substring(string @string, int n, int expectCount)
        {
            //Arrange
            //Act
            var res = Result.repeatedString(@string, n);

            //Assert
            res.Should().Be(expectCount);
        }
    }
}
