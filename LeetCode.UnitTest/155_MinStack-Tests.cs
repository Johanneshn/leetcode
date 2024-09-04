namespace LeetCode.UnitTest;

public class _155_MinStack_Tests
{
    [Fact]
    public void Solution()
    {
        var minStack = new _155_MinStack();

        minStack.Push(-2);
        minStack.Push(0);
        minStack.Push(-3);
        var param1 = minStack.GetMin(); // return -3
        minStack.Pop();
        var param2 = minStack.Top(); // return 0
        var param3 = minStack.GetMin(); // return -2

        Assert.Equal(-3, param1);
        Assert.Equal(0, param2);
        Assert.Equal(-2, param3);
    }
}