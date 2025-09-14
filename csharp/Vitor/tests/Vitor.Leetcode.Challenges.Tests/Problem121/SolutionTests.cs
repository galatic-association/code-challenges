using System.Collections;
using System.Collections.Generic;
using Vitor.Leetcode.Challenges.Problem121;
using Xunit;

namespace Vitor.Leetcode.Challenges.Tests.Problem121
{
    public class SolutionTests
    {

        public static IEnumerable<object[]> Scenarios
            => new object[][]
            {
                new object[] { new[] { 7, 1, 5, 3, 6, 4 }, 5 },
                new object[] { new[] { 2,4,1}, 2 },
                new object[] { new[] { 3, 2, 6, 5, 0, 3 }, 4 },
            };

        [Theory]
        [MemberData(nameof(Scenarios))]
        public void Should_Get_Max_Profit(int[] prices, int expectedMaxProfit)
        {
            //Arrange
            var sut = new Solution();

            //Act
            var result = sut.MaxProfit(prices);

            //Assert
            Assert.Equal(expectedMaxProfit, result);
        }
    }
}
