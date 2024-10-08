namespace LeetCode.UnitTest;

public class _001_TwoSum_Tests
{
    [Theory]
    [InlineData(new[] {2, 7, 11, 15}, 9, new[] {0, 1})]
    [InlineData(new[] {3,2,4}, 6, new[] {1, 2})]
    [InlineData(new[] {3,3}, 6, new[] {0, 1})]
    public void Solution(int[] nums, int target, int[] expected)
    {
        var actual = _001_TwoSum.TwoSum(nums, target);
        
        Assert.Equal(expected, actual);
    }
}