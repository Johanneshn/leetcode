namespace LeetCode.UnitTest;

public class _020_ValidParentheses_Tests {
    [Theory]
    [InlineData("()", true)]
    [InlineData("()[]{}", true)]
    [InlineData("(]", false)]
    [InlineData("((", false)]
    [InlineData("{[]}", true)]
    [InlineData(")(){}", false)]
    public void Solution(string s, bool expected)
    {
        var actual = _020_ValidParentheses.IsValid(s);
        Assert.Equal(expected, actual);
    } 
}