using System;

namespace Vitor.Leetcode.Challenges.Problem238
{
    public class Solution
    {
        public int[] ProductExceptSelf(int[] nums)
        {
            if (nums.Length is 0)
                return Array.Empty<int>();

            var posfix = new int[nums.Length];
            var prefix = new int[nums.Length];

            prefix[0] = nums[0];
            posfix[nums.Length - 1] = nums[nums.Length - 1];

            for (var i = 1; i < nums.Length; i++)
                prefix[i] = prefix[i - 1] * nums[i];

            for (var i = nums.Length - 1; i > 0; i--)
                posfix[i - 1] = posfix[i] * nums[i - 1];

            var answer = new int[nums.Length];

            answer[0] = posfix[1];

            for (var i = 1; i < nums.Length - 1; i++)
                answer[i] = posfix[i + 1] * prefix[i - 1];

            answer[nums.Length - 1] = prefix[nums.Length - 2];

            return answer;
        }
    }
}
