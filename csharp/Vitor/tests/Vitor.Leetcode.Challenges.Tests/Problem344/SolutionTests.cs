using Xunit;
using FluentAssertions;

namespace Vitor.Leetcode.Challenges.Problem344.Tests
{
    public class SolutionTests
    {
        [Fact]        
        public void Should_Return_Reverse_Chars_Array()
        {   
            var input = new char[] {'h','e', 'l','l', 'o'};
            var sut = new Solution();
            sut.ReverseString(input);
            input.Should().Equal(new char[] {'o','l', 'l','e', 'h'} );
        }
    }
}
