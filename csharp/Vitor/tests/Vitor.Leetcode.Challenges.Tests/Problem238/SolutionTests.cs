using System.Collections;
using System.Collections.Generic;
using Vitor.Leetcode.Challenges.Problem238;
using Xunit;

namespace Vitor.Leetcode.Challenges.Tests.Problem238
{
    public class SolutionTests
    {
        public static IEnumerable<object[]> Scenarios
            => new object[][]
        {
            new object[] { new[] { 1, 2, 3, 4 }, new[] {24, 12, 8, 6 } },
            new object[] { new[] { -1, 1, 0, -3, 3 }, new[] { 0, 0, 9, 0, 0 } }
        };


        [Theory]
        [MemberData(nameof(Scenarios))]
        public void Solution_Should_Return_Array_With_Product_Except_Self(int[] arr, int[] expectedArray)
        {
            //Arrange
            var sut = new Solution();

            //Act
            var result = sut.ProductExceptSelf(arr);

            //Assert
            Assert.Equal(expectedArray, result);
        }

        [Theory]
        [MemberData(nameof(Scenarios))]
        public void Solution2_Should_Return_Array_With_Product_Except_Self(int[] arr, int[] expectedArray)
        {
            //Arrange
            var sut = new Solution2();

            //Act
            var result = sut.ProductExceptSelf(arr);

            //Assert
            Assert.Equal(expectedArray, result);
        }
    }
}
