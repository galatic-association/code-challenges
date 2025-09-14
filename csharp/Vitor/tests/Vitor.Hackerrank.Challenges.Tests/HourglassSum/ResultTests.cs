using System.Collections.Generic;
using Vitor.Hackerrank.Challenges.HourglassSum;
using Xunit;

namespace Vitor.Hackerrank.Challenges.Tests.HourglassSum
{
    public sealed class ResultTests
    {
        [Theory]
        [MemberData(nameof(Scenarios))]
        public void Should_Return_Exact_Max_Hourglass_Sum(List<List<int>> arr, int expectedMaxSum)
        {
            //Arrange
            //Act
            var res = Result.hourglassSum(arr);

            //Assert
            Assert.Equal(expectedMaxSum, res);
        }

        public static IEnumerable<object[]> Scenarios()
        {

            yield return new object[]
            {
                 new List<List<int>>()
                    {
                       new List<int> {-9,-9,-9,1,1,1},
                       new List<int> {0,-9,0,4,3,2},
                       new List<int> {-9,-9,-9,1,2,3},
                       new List<int> {0,0,8,6,6,0},
                       new List<int> {0,0,0,-2,0,0},
                       new List<int> {0,0,1,2,4,0},
                    },
                    28
            };
        }
    }
}
