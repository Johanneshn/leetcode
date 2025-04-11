using NuGet.Frameworks;

namespace LeetCode.UnitTest;

public class _739_DailyTemperatures_Tests
{
    [Theory]
    [InlineData(new[] { 30, 40, 50, 60 }, new[] { 1, 1, 1, 0 })]
    [InlineData(new[] { 73, 74, 75, 71, 69, 72, 76, 73 }, new[] { 1, 1, 4, 2, 1, 1, 0, 0 })]
    [InlineData(new[] { 30, 60, 90 }, new[] { 1, 1, 0 })]
    public void Solution(int[] input, int[] expected)
    {
        var actual = _739_DailyTemperatures.DailyTemperatures(input);
        Assert.Equal(expected, actual);
    }
}