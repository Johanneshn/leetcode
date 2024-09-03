namespace LeetCode.UnitTest;

public class _011_ContainerWithMostWaterTests {

    [Theory]
    [InlineData(new[] {1,8,6,2,5,4,8,3,7}, 49)]
    [InlineData(new[] {1,1}, 1)]
    public void Solution(int[] input, int expected)
    {
        var actual = _011_ContainerWithMostWater.MaxArea(input);
        Assert.Equal(expected, actual);
    }
}