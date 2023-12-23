namespace Vitor.Leetcode.Challenges.Problem1768
{
    public class Solution
    {
        public string MergeAlternately(string word1, string word2)
        {
            var pointer = 0;
            var result = new char[word1.Length + word2.Length];
            var current = 0;
            while (current < result.Length && pointer < word1.Length && pointer < word2.Length)
            {
                result[current] = word1[pointer];
                result[current + 1] = word2[pointer];
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

            return new string(result);

            void FillRemaningValues(string word)
            {
                for (var i = current; i < result.Length; i++, pointer++)
                {
                    result[i] = word[pointer];
                }
            }
        }
    }
}
