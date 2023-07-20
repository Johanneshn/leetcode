namespace LeetCode.UnitTest;

public class _049_GroupAnagrams_Tests
{
    public static readonly TheoryData<string[], IList<IList<string>>> Case1 =
        new()
        {
            {
                new[] { "eat", "tea", "tan", "ate", "nat", "bat" },
                new List<IList<string>>()
                {
                    new List<string>() { "bat" },
                    new List<string>() { "nat", "tan" },
                    new List<string>() { "ate", "eat", "tea" },
                }
            }
        };

    public static readonly TheoryData<string[], IList<IList<string>>> Case2 =
        new()
        {
            {
                new[] { "" },
                new List<IList<string>>()
                {
                    new List<string>() { "" },
                }
            }
        };

    public static readonly TheoryData<string[], IList<IList<string>>> Case3 =
        new()
        {
            {
                new[] { "a" },
                new List<IList<string>>()
                {
                    new List<string>() { "a" },
                }
            }
        };

    static bool AreResultIdentical(IList<IList<string>> list1, IList<IList<string>> list2)
    {
        var x = list1.SelectMany(i => i).Order();
        var y = list2.SelectMany(i => i).Order();

        var r1 = string.Join(",", x);
        var r2 = string.Join(",", y);

        return r1 == r2;
    }

    [Theory]
    [MemberData(nameof(Case1))]
    [MemberData(nameof(Case2))]
    [MemberData(nameof(Case3))]
    public void Solution(string[] input, IList<IList<string>> expected)
    {
        var sut = _049_GroupAnagrams.GroupAnagrams(input);
        Assert.True(AreResultIdentical(expected, sut));
    }
}