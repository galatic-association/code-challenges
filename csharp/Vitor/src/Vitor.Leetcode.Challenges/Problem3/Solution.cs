using System;
using System.Collections.Generic;

namespace Vitor.Leetcode.Challenges.Problem3
{
    public class Solution
    {
        public int LengthOfLongestSubstring(string s)
        {
            if (s is "")
                return 0;

            if (s is { Length: 1 })
                return 1;

            var maxSubstringLength = 0;

            var set = new HashSet<char>();
            for (var i = 0; i < s.Length - 1; i++)
            {
                set.Add(s[i]);
                for (var j = i+1; j < s.Length; j++)
                {
                    if (set.Contains(s[j]))
                    {
                        break;
                    }
                    set.Add(s[j]);
                }
                maxSubstringLength = Math.Max(set.Count, maxSubstringLength);
                set.Clear();
            }

            return maxSubstringLength;
        }
    }
}
