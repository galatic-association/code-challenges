using System.Text;

namespace Vitor.Leetcode.Challenges.Problem1768
{
    public class Solution
    {
        public string MergeAlternately(string word1, string word2)
        {
            var pointer = 0;
            var totalLength = word1.Length + word2.Length;
            var builder = new StringBuilder();
            var current = 0;
            while (pointer < word1.Length && pointer < word2.Length)
            {
                builder.Insert(current, word1[pointer]);
                builder.Insert(current+1, word2[pointer]);
                current += 2;
                pointer++;
            }

            if (pointer >= word1.Length)
            {
                FillRemaningValues(word2);
            }
            else if (pointer >= word2.Length)
            {
                FillRemaningValues(word1);
            }

            return builder.ToString();

            void FillRemaningValues(string word)
            {
                for (var i = current; i < totalLength; i++, pointer++)
                {
                    builder.Insert(i, word[pointer]);
                }
            }
        }
    }
}
