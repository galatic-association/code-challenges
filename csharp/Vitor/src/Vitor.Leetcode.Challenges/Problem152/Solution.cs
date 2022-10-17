using System;

namespace Vitor.Leetcode.Challenges.Problem152
{
    public class Solution
    {
        //Same principal as Problem53
        //https://leetcode.com/problems/maximum-product-subarray/discuss/1608862/JAVA-or-3-Solutions-or-Detailed-Explanation-Using-Image
        public int MaxProduct(int[] nums)
        {
            if (nums.Length == 1)
                return nums[0];

            var max = nums[0];
            var min = nums[0];
            var maxProduct = nums[0];

            for (var i = 1; i < nums.Length; i++)
            {
                if (nums[i] < 0)
                    (max, min) = (min, max);

                max = Math.Max(nums[i], max * nums[i]);
                min = Math.Min(nums[i], min * nums[i]); //save this value to keep track the negative value
                maxProduct = Math.Max(max, maxProduct);
            }

            return maxProduct;
        }
    }
}
