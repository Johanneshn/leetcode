namespace LeetCode.UnitTest;

public class _015_3Sum_Tests
{
    public static readonly TheoryData<int[], IList<IList<int>>> Case1 =
        new()
        {
            {
                new[] { -1, 0, 1, 2, -1, -4 },
                new List<IList<int>>()
                {
                    new List<int>() { -1, -1, 2 },
                    new List<int>() { -1, 0, 1 },
                }
            }
        };

    public static readonly TheoryData<int[], IList<IList<int>>> Case2 =
        new()
        {
            {
                new[] { 0, 1, 1 },
                new List<IList<int>>()
            }
        };

    public static readonly TheoryData<int[], IList<IList<int>>> Case3 =
        new()
        {
            {
                new[] { 0, 0, 0 },
                new List<IList<int>>()
                {
                    new List<int>() { 0, 0, 0 }
                }
            }
        };

    [Theory]
    [MemberData(nameof(Case1))]
    [MemberData(nameof(Case2))]
    [MemberData(nameof(Case3))]
    public void Solution(int[] nums, IList<IList<int>> expected)
    {
        var sut = _015_3Sum.ThreeSum(nums);
        Assert.Equal(expected, sut);
    }
}