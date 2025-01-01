namespace LeetCode.UnitTest;

public class _022_GenerateParentheses_Tests {
    [Theory]
    [InlineData(1, new[]{"()"})]
    [InlineData(3, new[]{"((()))","(()())","(())()","()(())","()()()"})]
    public void Solution(int n, string[] expected)
    {
        var actual = _022_GenerateParentheses.GenerateParenthesis(n);
        Assert.Equal(expected, actual);
    }
}
