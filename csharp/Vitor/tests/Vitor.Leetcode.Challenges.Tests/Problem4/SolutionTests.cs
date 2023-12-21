using Xunit;
using Vitor.Leetcode.Challenges.Problem4;
using System.Collections.Generic;
using FluentAssertions;

namespace Vitor.Leetcode.Challenges.Tests.Problem4
{
    public class SolutionTests
    {
        public static IEnumerable<object[]> Scenarios()
        {
            yield return new object[] { new[] { 1, 3 }, new[] { 2 }, 2.0 };
            yield return new object[] { new[] { 2 }, new[] { 1, 3 }, 2.0 };
            yield return new object[] { new[] { 1, 2 }, new[] { 3, 4 }, 2.5 };
        }

        [Theory]
        [MemberData(nameof(Scenarios))]
        public void TestName(int[] input1, int[] input2, double expectedResult)
        {
            //Arrange
            var sut = new Solution();

            //Act
            var result = sut.FindMedianSortedArrays(input1, input2);

            //Assert
            result.Should().Be(expectedResult);
        }
    }
}
