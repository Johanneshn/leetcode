namespace LeetCode.UnitTest;

public class _128_LongestConsecutiveSequence_Tests
{
    [Theory]
    [InlineData(new[] { 100, 4, 200, 1, 3, 2 }, 4)]
    [InlineData(new[] { 9, 1, 4, 7, 3, -1, 0, 5, 8, -1, 6 }, 7)]
    [InlineData(new int[0], 0)]
    public void Solution(int[] nums, int expected)
    {
        var actual = _128_LongestConsecutiveSequence.LongestConsecutive(nums);

        Assert.Equal(expected, actual);
    }
}