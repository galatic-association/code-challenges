using System.Collections.Generic;

namespace Vitor.Leetcode.Challenges.Problem217
{
    public class Solution
    {
        public bool ContainsDuplicate(int[] nums)
        {
            var set = new HashSet<int>();

            foreach (var num in nums)
            {
                if (set.Contains(num))
                    return true;
                set.Add(num);
            }

            return false;
        }
    }
}
