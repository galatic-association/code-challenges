namespace Vitor.Leetcode.Challenges.Problem125
{
    public class Solution
    {
        public bool IsPalindrome(string s)
        {
            if (string.IsNullOrEmpty(s))
                return true;

            var leftPosition = 0;
            var rightPosition = s.Length - 1;

            while (leftPosition < rightPosition)
            {
                var leftChar = s[leftPosition];
                var rightChar = s[rightPosition];

                if (!char.IsLetterOrDigit(leftChar))
                {
                    leftPosition++;
                    continue;
                }

                if (!char.IsLetterOrDigit(rightChar))
                {
                    rightPosition--;
                    continue;
                }

                if (char.ToLower(rightChar) != char.ToLower(leftChar))
                    return false;

                rightPosition--;
                leftPosition++;
            }

            return true;
        }
    }
}