using System.Linq;

namespace Vitor.Hackerrank.Challenges.RepeatedString
{
    public static class Result
    {
        public static long repeatedString(string s, long n)
        {
            if (string.IsNullOrEmpty(s))
                return 0;

            long countInString = s.Count(c => c == 'a');
            long fullRepetitions = n / s.Length;
            long remainingChars = n % s.Length;
            
            long totalCount = countInString * fullRepetitions;
            
            if (remainingChars > 0)
            {
                string remainingString = s.Substring(0, (int)remainingChars);
                totalCount += remainingString.Count(c => c == 'a');
            }
            
            return totalCount;
        }
    }
}
