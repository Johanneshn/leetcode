namespace LeetCode;

public abstract class _022_GenerateParentheses
{
    public static string[] GenerateParenthesis(int n)
    {
        var res = new List<string>();
        Backtrack(0, 0, n, res, new Stack<char>());
        return res.ToArray();
    }

    private static void Backtrack(int openN, int closedN, int n, ICollection<string> res, Stack<char> stack)
    {
        if (openN == closedN && openN == n)
        {
            res.Add(string.Join("", stack.Reverse()));
            return;
        }

        if (openN < n)
        {
            stack.Push('(');
            Backtrack(openN + 1, closedN, n, res, stack);
            stack.Pop();
        }

        if (closedN < openN)
        {
            stack.Push(')');
            Backtrack(openN, closedN + 1, n, res, stack);
            stack.Pop();
        }
    }
}