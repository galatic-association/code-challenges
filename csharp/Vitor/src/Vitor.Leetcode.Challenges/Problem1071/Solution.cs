using System.Linq;

namespace Vitor.Leetcode.Challenges.Problem1071
{
    public class Solution
    {
        public string GcdOfStrings(string str1, string str2)
        {
            if (str1.Length > str2.Length)
            {
                return GcdOfStrings(str2, str1);
            }

            var maxGcd = string.Empty;
            for (var i = 0; i < str1.Length; i++)
            {
                var canditateGcd = str1[..(i+1)];
                if (str2.Replace(canditateGcd, "") is "" && str1.Replace(canditateGcd, "") is "")
                {
                    maxGcd = maxGcd.Length < canditateGcd.Length ? canditateGcd : maxGcd;
                }
            }

            return maxGcd;
        }
    }
}
