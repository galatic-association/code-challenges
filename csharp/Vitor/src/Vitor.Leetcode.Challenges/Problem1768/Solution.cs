using System.Text;

namespace Vitor.Leetcode.Challenges.Problem1768
{
    public class Solution
    {
        public string MergeAlternately(string word1, string word2)
        {
            var pointer1 = 0;
            var pointer2 = 0;
            var builder = new StringBuilder();
            var totalLength = word1.Length + word2.Length;

            while (pointer1 + pointer2 < totalLength)
            {
                if (pointer1 < word1.Length)
                    builder.Append(word1[pointer1++]);
                if (pointer2 < word2.Length)
                    builder.Append(word2[pointer2++]);
            }

            return builder.ToString();
        }
    }
}
