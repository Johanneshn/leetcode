namespace LeetCode.UnitTest;

public class _150_EvaluateReversePolishNotation_Tests {
    [Theory]
    [InlineData(new[] { "2","1","+","3","*" }, 9)]
    [InlineData(new[] {"4","13","5","/","+" }, 6)]
    [InlineData(new[] {"10","6","9","3","+","-11","*","/","*","17","+","5","+" }, 22)]
    public void Solution(string[] input, int expected)
    {
        var actual = _150_EvaluateReversePolishNotation.EvalRPN(input);

        Assert.Equal(expected, actual);
    }
}