namespace LeetCode.UnitTest;

public class _238_ProductOfArrayExceptSelfTests

{
    [Theory]
    [InlineData(new[] { 1, 2, 3, 4 }, new[] { 24, 12, 8, 6 })]
    [InlineData(new[] { -1, 1, 0, -3, 3 }, new[] { 0, 0, 9, 0, 0 })]
    [InlineData(new[] { 1, 1 }, new[] { 1, 1 })]
    [InlineData(new[] { 0, 0 }, new[] { 0, 0 })]
    public void Solution(int[] nums, int[] expected)
    {
        var actual = _238_ProductOfArrayExceptSelf.ProductExceptSelf(nums);

        Assert.Equal(expected, actual);
    }
}