using FluentAssertions;
using System.Collections.Generic;
using Vitor.Leetcode.Challenges.Problem153;
using Xunit;

namespace Vitor.Leetcode.Challenges.Tests.Problem153
{
    public class SolutionTests
    {
        public static IEnumerable<object[]> Scenarios()
        {
            yield return new object[] { new int[] { 3, 4, 5, 1, 2 }, 1 };
            yield return new object[] { new int[] { 4, 5, 6, 7, 0, 1, 2 }, 0 };
            yield return new object[] { new int[] { 11, 13, 15, 17 }, 11 };
        }

        [Theory]
        [MemberData(nameof(Scenarios))]
        public void TwoPointerApproach_Should_Return_The_Mininum_Value(int[] arr, int expectedMin)
        {
            //Arrange
            var sut = new Solution();

            //Act
            var result = sut.FindMin(arr);

            //Assert
            result.Should().Be(expectedMin);
        }

        [Theory]
        [MemberData(nameof(Scenarios))]
        public void ModifiedBinarySearch_Should_Return_The_Mininum_Value(int[] arr, int expectedMin)
        {
            //Arrange
            var sut = new Solution2();

            //Act
            var result = sut.FindMin(arr);

            //Assert
            result.Should().Be(expectedMin);
        }
    }
}
