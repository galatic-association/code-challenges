using FluentAssertions;
using System.Collections.Generic;
using Vitor.Leetcode.Challenges.Problem1071;
using Xunit;

namespace Challenges.Tests.Problem1071
{
    public class SolutionTests
    {
        public static IEnumerable<object[]> Scenarios()
        {
            //yield return new object[] { "ABCABC", "ABC", "ABC" };
            //yield return new object[] { "ABABAB", "ABAB", "AB" };
            //yield return new object[] { "LEET", "CODE", "" };
            yield return new object[] { "ABABABAB", "ABAB", "ABAB" };
        }

        [Theory]
        [MemberData(nameof(Scenarios))]
        public void Should_Get_Gcd_Of_Strings(string str1, string str2, string expected)
        {
            //Arrange
            var sut = new Solution();

            //Act
            var result = sut.GcdOfStrings(str1, str2);

            //Assert
            result.Should().Be(expected);
        }
    }
}
