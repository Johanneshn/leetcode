namespace LeetCode;
/*
 * https://leetcode.com/problems/best-time-to-buy-and-sell-stock/submissions/950954249/
 * Runtime: 230 ms - O(n)
 * Memory: 50 MB - 0(1) 
 */
public static class _121_BestTimeToBuyAndSellStock {
    public static int MaxProfit(int[] prices)
    {
        var maxProfit = 0;
        var min = int.MaxValue;
        foreach (var price in prices)
        {
            if (price < min)
            {
                min = price;
            }

            var profit = price - min;
            if (profit > maxProfit)
            {
                maxProfit = profit;
            }
        }
        return maxProfit;
    } 
}