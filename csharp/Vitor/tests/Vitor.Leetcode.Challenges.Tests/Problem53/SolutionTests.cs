using System.Collections.Generic;
using Vitor.Leetcode.Challenges.Problem53;
using Xunit;

namespace Vitor.Leetcode.Challenges.Tests.Problem53
{
    public class SolutionTests
    {
        public static IEnumerable<object[]> Scenarios()
        {
            yield return new object[] { new int[] { -2, 1, -3, 4, -1, 2, 1, -5, 4 }, 6 };
            yield return new object[] { new int[] { 1 }, 1 };
            yield return new object[] { new int[] { 5, 4, -1, 7, 8 }, 23 };
        }


        [Theory]
        [MemberData(nameof(Scenarios))]
        public void MaxSubArray_NaiveApproach_Should_Return_Correct_Values(int[] @case, int expectedSum)
        {
            //Arrange
            var sut = new Solution();

            //Act
            var result = sut.MaxSubArray(@case);

            //Assert
            Assert.Equal(expectedSum, result);
        }

        [Theory]
        [MemberData(nameof(Scenarios))]
        public void MaxSubArray_DynamicProgrammingApproach_Should_Return_Correct_Values(int[] @case, int expectedSum)
        {
            //Arrange
            var sut = new Solution2();

            //Act
            var result = sut.MaxSubArray(@case);

            //Assert
            Assert.Equal(expectedSum, result);
        }

    }
}
