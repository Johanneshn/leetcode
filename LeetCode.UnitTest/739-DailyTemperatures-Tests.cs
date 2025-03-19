using NuGet.Frameworks;

namespace LeetCode.UnitTest;

public class _739_DailyTemperatures_Tests
{
    [Theory]
    [InlineData(new[] { 30, 40, 50, 60 }, new[] { 1, 1, 1, 0 })]
    public void Solution(int[] input, int[] expected)
    {
        var actual = _739_DailyTemperatures.DailyTemperatures(input);
        Assert.Equal(actual, expected);
    }
}