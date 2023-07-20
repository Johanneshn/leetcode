namespace LeetCode.UnitTest;

public class _347_TopKFrequentElements_Tests
{
    [Theory]
    [InlineData(new[] { 1, 1, 1, 2, 2, 2, 3 }, 2, new[] { 1, 2 })]
    [InlineData(new[] { 1 }, 1, new[] { 1 })]
    [InlineData(new[] { -1, -1, -2, -2, 0, 1 }, 2, new[] { -1, -2 })]
    public void Solution(int[] nums, int k, int[] expected)
    {
        var sut = _347_TopKFrequentElements.TopKFrequent(nums, k);

        Assert.Equal(expected, sut);
    }
}