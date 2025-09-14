using System.Collections.Generic;
using Vitor.Leetcode.Challenges.Problem1768;
using Xunit;

namespace Vitor.Leetcode.Challenges.Tests.Problem1768
{
    public class SolutionTests
    {
        public static IEnumerable<object[]> Scenarios()
        {
            yield return new object[] { "abcd", "pq", "apbqcd" };
            yield return new object[] { "abc", "pqr", "apbqcr" };
            
        }

        [Theory]
        [MemberData(nameof(Scenarios))]
        public void Should_Merge_Alternately(string word1, string word2, string expected)
        {
            //Arrange
            var sut = new Solution();

            //Act
            var result = sut.MergeAlternately(word1, word2);

            //Assert
            Assert.Equal(expected, result);
        }
    }
}
