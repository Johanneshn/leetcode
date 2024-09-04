namespace LeetCode.UnitTest;

public class _042_TrappingWaterTests {
    [Theory]
    [InlineData(new[] {0,1,0,2,1,0,1,3,2,1,2,1},6)]
    [InlineData(new[] {4,2,0,3,2,5},9)]
    public void Solution(int[] input, int expected)
    {
        var actual = _042_TrappingWater.Trap(input);
        Assert.Equal(expected, actual);
    }
}
