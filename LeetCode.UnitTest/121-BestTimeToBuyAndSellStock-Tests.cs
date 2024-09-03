namespace LeetCode.UnitTest;
/*
 * https://leetcode.com/problems/best-time-to-buy-and-sell-stock/submissions/950954249/
 * Runtime: 230 ms - O(n)
 * Memory: 50 MB - O(1)
 */
public class _121_BestTimeToBuyAndSellStock_Tests {
    [Theory]
    [InlineData(new[] {7,1,5,3,6,4}, 5)]
    [InlineData(new[] {7,6,4,3,1}, 0)]
    public void Solution(int[] nums, int result)
    {
        var actual = _121_BestTimeToBuyAndSellStock.MaxProfit(nums);
        
        Assert.Equal(result, actual);
    }
}