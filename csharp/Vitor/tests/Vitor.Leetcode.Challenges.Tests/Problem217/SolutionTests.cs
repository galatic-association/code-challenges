using System.Collections.Generic;
using FluentAssertions;
using Microsoft.VisualBasic;
using Vitor.Leetcode.Challenges.Problem217;
using Xunit;

namespace Vitor.Leetcode.Challenges.Tests.Problem217
{
    public class SolutionTests
    {
        public static IEnumerable<object[]> Scenarios => new object[][]
        {
            new object[]
            {
                new[] { 1, 2, 3, 1 }, true
            },
            new object[]
            {
                new[] { 1,2,3,4 }, false
            },
            new object[]
            {
                new[] { 1,1,1,3,3,4,3,2,4,2 }, true
            },
        };

        [Theory]
        [MemberData(nameof(Scenarios))]
        public void Should_Return_Correct_Value(int[] nums, bool expectedReturn)
        {
            //Arrange
            var sut = new Solution();

            //Act
            var result = sut.ContainsDuplicate(nums);

            //Assert
            result.Should().Be(expectedReturn);
        }
    }
}
