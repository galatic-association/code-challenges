using Xunit;
using FluentAssertions;

namespace Vitor.Leetcode.Challenges.Problem125.Tests
{
    public class SolutionTests
    {
        [Theory]
        [InlineData("race a car", false)]
        [InlineData( "A man, a plan, a canal: Panama", true)]
        [InlineData( "", true)]
        public void Should_Verify_Valid_Palindrome_Words(string word, bool expectResult)
        {
            var sut = new Solution();
            var actual = sut.IsPalindrome(word);
            actual.Should().Be(expectResult);
        }
    }
}
