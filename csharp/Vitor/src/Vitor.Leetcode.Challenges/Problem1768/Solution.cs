using System;
using System.Text;

namespace Vitor.Leetcode.Challenges.Problem1768
{
    public class Solution
    {
        public string MergeAlternately(string word1, string word2)
        {
            var builder = new StringBuilder(word1.Length + word2.Length);
            var maxLength = Math.Max(word1.Length, word2.Length);
            var i = 0;
            do
            {
                if (i < word1.Length)
                    builder.Append(word1[i]);
                if (i < word2.Length)
                    builder.Append(word2[i]);
            } while (++i < maxLength);
           
            return builder.ToString();
        }
    }
}
