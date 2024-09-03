namespace LeetCode.UnitTest;

public class _125_ValidPalindrome_Tests
{
    [Theory]
    [InlineData("A man, a plan, a canal: Panama", true)]
    [InlineData("ala", true)]
    [InlineData("alax", false)]
    [InlineData("a", true)]
    [InlineData("", true)]
    [InlineData("0P", false)]
    public void Solution(string s, bool expected)
    {
        var actual = _125_ValidPalindrome.IsPalindrome(s);
        Assert.Equal(expected, actual);
    }
}