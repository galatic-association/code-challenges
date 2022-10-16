using System;

namespace Vitor.Leetcode.Challenges.Problem53
{
    public class Solution2
    {
        //https://www.youtube.com/watch?v=Ut7q0TS6sfY - Link to solution and explanation
        //Kadane's Algorithm
        public int MaxSubArray(int[] nums)
        {
            if (nums.Length == 1)
                return nums[0];

            var maxCurrentSum = nums[0];
            var maxSum = nums[0];

            for (var i = 1; i < nums.Length; i++)
            {
                maxCurrentSum = Math.Max(nums[i], maxCurrentSum + nums[i]); //decide if will restart the array or sum to the current one
                maxSum = Math.Max(maxCurrentSum, maxSum);
            }

            return maxSum;
        }
    }
}
