namespace Vitor.Leetcode.Challenges.Problem344
{   
    public class Solution
    {
        public void ReverseString(char[] s)
        {                       
            for (var i = 0; i < s.Length / 2; i++)
            {
                var aux = s[i];
                s[i] = s[s.Length - 1 - i];
                s[s.Length - 1 - i] = aux;
            }
        }
    }
}
