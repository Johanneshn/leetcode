using NuGet.Frameworks;

namespace LeetCode.UnitTest;

public class _853_Car_Fleet_Tests
{
    [Theory]
    [InlineData(3, 12, new[] { 10, 8, 0, 5, 3 }, new[] { 2, 4, 1, 1, 3 })]
    [InlineData(1, 10, new[] { 3 }, new[] { 3 })]
    [InlineData(1, 100, new[] { 0, 2, 4 }, new[] { 4, 2, 1 })]
    public void Solution(int expected, int target, int[] position, int[] speed)
    {
        var actual = _853_CarFleet.CarFleet(target, position, speed);
        Assert.Equal(expected, actual);
    }
}
