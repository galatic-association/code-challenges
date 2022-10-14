using System;

namespace Vitor.Leetcode.Challenges.Problem238
{
    public class Solution2
    {
        public int[] ProductExceptSelf(int[] nums)
        {
            if (nums.Length is 0)
                return Array.Empty<int>();

            var answer = new int[nums.Length];
            answer[0] = 1;

            var prefix = 1;
            for (var i = 0; i < nums.Length; i++)
            {
                answer[i] = prefix;
                prefix *= nums[i];
            }

            var postfix = 1;
            for (int i = nums.Length - 1; i >= 0; i--)
            {
                answer[i] *= postfix;
                postfix *= nums[i];
            }
           
            return answer;
        }
    }
}
