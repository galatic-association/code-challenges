using FluentAssertions;
using System.Collections.Generic;
using Vitor.Leetcode.Challenges.Problem152;
using Xunit;

namespace Vitor.Leetcode.Challenges.Tests.Problem152
{
    public class SolutionTests
    {
        public static IEnumerable<object[]> Scenarios()
        {
            yield return new object[] { new int[] { 2, 3, -2, 4 }, 6 };
            yield return new object[] { new int[] { -2, 0, -1 }, 0 };
            yield return new object[] { new int[] { -2, 3, -4 }, 24 };
            yield return new object[] { new int[] { 3, -1, 4 }, 4 };
            yield return new object[] { new int[] { 0, 2 }, 2 };
            yield return new object[] { new int[] { 7, -2, -4 }, 56 };
        }

        [Theory]
        [MemberData(nameof(Scenarios))]
        public void MaxProduct_DynamicProgrammingApproach_Should_Return_Correct_Values(int[] @case, int expectedSum)
        {
            //Arrange
            var sut = new Solution();

            //Act
            var result = sut.MaxProduct(@case);

            //Assert
            result.Should().Be(expectedSum);
        }
    }
}
