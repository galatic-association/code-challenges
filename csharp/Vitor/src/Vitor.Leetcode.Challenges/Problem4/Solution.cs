using System;

namespace Vitor.Leetcode.Challenges.Problem4
{
    public class Solution
    {
        public double FindMedianSortedArrays(int[] nums1, int[] nums2)
        {
            var totalLength = nums1.Length + nums2.Length;
            var medianPosition = (int)Math.Floor((totalLength) / 2d);
            var nums = new int[2];
            var pointer1 = 0;
            var pointer2 = 0;

            var currentPosition = -1;
            while (currentPosition < medianPosition)
            {
                currentPosition++;

                if (pointer1 > nums1.Length - 1 || (pointer2 < nums2.Length && nums1[pointer1] > nums2[pointer2]))
                {
                    nums[currentPosition % 2] = nums2[pointer2];
                    pointer2++;
                }
                else
                {
                    nums[currentPosition % 2] = nums1[pointer1];
                    pointer1++;
                }
            }

            if (totalLength % 2 == 0)
            {
                return (nums[0] + nums[1]) / 2D;
            }

            return nums[currentPosition % 2];
        }
    }
}
