namespace LeetCode.UnitTest;

public class _242_ValidAnagramTests
{
    [Theory]
    [InlineData("anagram", "nagaram", true)]
    [InlineData("car", "cat", false)]
    [InlineData("aacc", "ccac", false)]
    public void Solution(string s, string t, bool expected)
    {
        var actual = _242_ValidAnagram.IsAnagram(s, t);
        
        Assert.Equal(actual, expected);
    }
}