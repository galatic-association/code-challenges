using System;

namespace Vitor.Leetcode.Challenges.Problem121
{
    public class Solution
    {
        public int MaxProfit(int[] prices)
        {
            var buyDay = 0;
            var sellDay = 1;
            var maxProfit = 0;

            while (sellDay < prices.Length)
            {
                if (prices[buyDay] < prices[sellDay])
                    maxProfit = Math.Max(maxProfit, prices[sellDay] - prices[buyDay]);
                else
                    buyDay+=sellDay;
                sellDay++;
            }

            return maxProfit;
        }
    }
}
