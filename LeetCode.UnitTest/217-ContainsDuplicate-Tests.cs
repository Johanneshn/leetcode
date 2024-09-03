namespace LeetCode.UnitTest;

public class _217_ContainsDuplicate_Tests
{
    [Theory]
    [InlineData(new[] { 1, 2, 3, 1 }, true)]
    [InlineData(new[] { 1, 2, 3, 4 }, false)]
    [InlineData(new[] { 1, 1, 1, 3, 3, 4, 3, 2, 4, 23 }, true)]
    public void Solution(int[] nums, bool expected)
    {
        var actual = _217_ContainsDuplicate.ContainsDuplicate(nums);
        Assert.Equal(actual, expected);
    }
}