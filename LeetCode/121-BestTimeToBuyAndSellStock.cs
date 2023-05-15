namespace LeetCode;

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