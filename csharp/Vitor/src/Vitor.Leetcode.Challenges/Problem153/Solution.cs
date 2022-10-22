namespace Vitor.Leetcode.Challenges.Problem153
{
    public class Solution
    {
        public int FindMin(int[] nums)
        {
            var left = 0;
            var right = nums.Length - 1;
            var min = nums[0];

            //this solution has the same complexity to a for loop with Math.Min();
            //o(n)

            while (left < right)
            {
                if (nums[left] > nums[right])
                {
                    left++;
                    min = nums[right];
                }
                else
                {
                    right--;
                    min = nums[left];
                }
            }

            return min;
        }
    }
}
