namespace Vitor.Leetcode.Challenges.Problem153
{
    public class Solution2
    {
        public int FindMin(int[] nums)
        {
            if (nums.Length == 1)
                return nums[0];

            var left = 0;
            var right = nums.Length - 1;

            if (nums[right] > nums[0])
                return nums[0];

            while (left < right)
            {
                var middle = (left + right) / 2;

                if (nums[middle] > nums[right])
                    left = middle + 1;
                else
                    right = middle;
            }

            return nums[left];
        }
    }
}
