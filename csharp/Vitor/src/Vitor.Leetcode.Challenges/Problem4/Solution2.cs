using System;

namespace Vitor.Leetcode.Challenges.Problem4
{
    public class Solution2
    {
        //Solution Video 
        // https://www.youtube.com/watch?v=QjrchMRAkew
        // https://ganeshprasad227.medium.com/logarithmic-algorithm-for-finding-median-of-two-sorted-arrays-of-different-sizes-aaecf302057e
        public double FindMedianSortedArrays(int[] nums1, int[] nums2)
        {
            // Ensure nums1 is the smaller array for simplicity
            if (nums1.Length > nums2.Length)
            {
                return FindMedianSortedArrays(nums2, nums1);
            }

            var totalLength = nums1.Length + nums2.Length;
            var left = 0;
            var right = nums1.Length;

            while (left <= right)
            {
                var midNums1Index = (int)Math.Floor((left + right) / 2d);
                var midNums2Index = (int)Math.Floor((totalLength + 1) / 2d) - midNums1Index;

                var x1 = midNums1Index - 1 < 0 ? int.MinValue : nums1[midNums1Index - 1];
                var y1 = midNums1Index == nums1.Length ? int.MaxValue : nums1[midNums1Index];

                var x2 = midNums2Index - 1 < 0 ? int.MinValue : nums2[midNums2Index - 1];
                var y2 = midNums2Index == nums2.Length ? int.MaxValue : nums2[midNums2Index];

                if (x1 <= y2 && x2 <= y1)
                {
                    // The partition is correct, we found the median
                    if (totalLength % 2 == 0)
                    {
                        return (Math.Max(x1, x2) + Math.Min(y1, y2)) / 2d;
                    }
                    else
                    {
                        return Math.Max(x1, x2);
                    }
                }
                else if (x1 > y2)
                {
                    // Move towards the left side of nums1
                    right = midNums1Index - 1;
                }
                else
                {
                    // Move towards the right side of nums1
                    left = midNums1Index + 1;
                }
            }

            return 0;
        }
    }
}
