using System;
using System.Collections.Generic;

namespace Vitor.Hackerrank.Challenges.HourglassSum
{
    public class Result
    {
        /*
         * Complete the 'hourglassSum' function below.
         *
         * The function is expected to return an INTEGER.
         * The function accepts 2D_INTEGER_ARRAY arr as parameter.
         */
        public static int hourglassSum(List<List<int>> arr)
        {
            var maxSum = int.MinValue;

            for (var i = 0; i < arr.Count - 2; i++)
                for (var j = 0; j < arr[i].Count - 2; j++)
                    maxSum = Math.Max(maxSum, GetHourglassSum(arr, i, j));

            return maxSum;
        }

        private static int GetHourglassSum(List<List<int>> arr, int currentRow, int currentCollumn)
        {
            var hourglass = new int[3, 3];

            var indexes = new (int Row, int Collumn)[]
            {
                (0 + currentRow, 0 + currentCollumn),
                (0 + currentRow, 1 + currentCollumn),
                (0 + currentRow, 2 + currentCollumn),
                (1 + currentRow, 1 + currentCollumn),
                (2 + currentRow, 0 + currentCollumn),
                (2 + currentRow, 1 + currentCollumn),
                (2 + currentRow, 2 + currentCollumn),
            };

            foreach (var index in indexes)
                hourglass[index.Row - currentRow, index.Collumn - currentCollumn] = arr[index.Row][index.Collumn];

            return hourglass[0, 0] + hourglass[0, 1] + hourglass[0, 2] +
                                     hourglass[1, 1] +
                   hourglass[2, 0] + hourglass[2, 1] + hourglass[2, 2];
        }
    }
}
