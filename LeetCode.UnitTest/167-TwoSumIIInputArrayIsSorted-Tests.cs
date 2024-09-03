namespace LeetCode.UnitTest;

public class _167_TwoSumIIInputArrayIsSorted_Tests
{
    [Theory]
    [InlineData(new[] { 2, 7, 11, 15 }, 9, new[] { 1, 2 })]
    [InlineData(new[] { 2, 3, 4 }, 6, new[] { 1, 3 })]
    [InlineData(new[] { -1, 0 }, -1, new[] { 1, 2 })]
    [InlineData(new[] { 5, 25, 75 }, 10, new[] { 1, 1 })]
    [InlineData(new[] { 5, 25, 75 }, 100, new[] { 2, 3 })]
    public void Solution(int[] nums, int target, int[] expected)
    {
        var actual = _167_TwoSumIIInputArrayIsSorted.TwoSum(nums, target);

        Assert.Equal(actual, expected);
    }
}