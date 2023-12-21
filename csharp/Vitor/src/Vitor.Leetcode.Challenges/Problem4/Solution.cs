using System;

namespace Vitor.Leetcode.Challenges.Problem4
{
    public class Solution
    {
        public double FindMedianSortedArrays(int[] nums1, int[] nums2)
        {
            var nums = new int[nums1.Length + nums2.Length];
            var pointer1 = 0;
            var pointer2 = 0;

            var currentPosition = -1;
            while (currentPosition < nums1.Length + nums2.Length - 1)
            {
                currentPosition++;

                if (pointer1 > nums1.Length - 1 || (pointer2 < nums2.Length && nums1[pointer1] > nums2[pointer2]))
                {
                    nums[currentPosition] = nums2[pointer2];
                    pointer2++;
                }
                else
                {
                    nums[currentPosition] = nums1[pointer1];
                    pointer1++;
                }
            }

            var totalLength = nums1.Length + nums2.Length;
            var middle = (int)Math.Floor(totalLength / 2.0);
            if ((nums1.Length + nums2.Length) % 2 == 0)
            {
                return (nums[middle] + nums[middle - 1]) / 2D;
            }

            return nums[middle];
        }
    }
}
