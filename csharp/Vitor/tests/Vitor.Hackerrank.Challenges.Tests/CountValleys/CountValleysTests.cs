using Vitor.Hackerrank.Challenges.CountingValleys;
using Xunit;

namespace Vitor.Hackerrank.Challenges.CountValleys.Tests
{
    public sealed class CountValleysTests
    {
        [Theory]
        [InlineData(8, "UDDDUDUU", 1)]
        [InlineData(10, "UDUUUDUDDD", 0)]
        [InlineData(12, "DDUUDDUDUUUD", 2)]
        public void Should_Return_Exact_Number_Of_Valleys_Traversed(int steps, string path, int expectValleysTraversed)
        {
            //Arrange
            //Act
            var res = Result.countingValleys(steps, path);

            //Assert
            Assert.Equal(expectValleysTraversed, res);
        }
    }
}
