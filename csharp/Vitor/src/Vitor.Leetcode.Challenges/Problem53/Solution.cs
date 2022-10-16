using System;

namespace Vitor.Leetcode.Challenges.Problem53
{
    public class Solution
    {
        public int MaxSubArray(int[] nums)
        {
            if (nums.Length == 1)
                return nums[0];

            var maxSum = int.MinValue;

            //i -> start windows position
            for (var i = 0; i < nums.Length; i++)
            {
                //j -> windowSize
                for (var j = 0; j < nums.Length-i; j++)
                {
                    var currentSum = 0;

                    //k -> current index
                    for (var k = i; k < i+j+1; k++)
                        currentSum += nums[k];
                    
                    maxSum = Math.Max(maxSum, currentSum);
                }
            }

            return maxSum;
        }
    }
}
