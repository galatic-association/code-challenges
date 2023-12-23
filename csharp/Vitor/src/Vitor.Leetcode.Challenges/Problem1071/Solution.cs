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

            for (var i = 0; i < str1.Length; i++)
            {
                var currentLength = str1.Length - i;

                if (str2.Length % currentLength != 0 && str1.Length % currentLength != 0)
                    continue;

                var canditateGcd = str1[..^i];

                if (canditateGcd is "" || (str2.Replace(canditateGcd, "") is "" && str1.Replace(canditateGcd, "") is ""))
                {
                    return canditateGcd;
                }
            }

            return "";
        }
    }
}
