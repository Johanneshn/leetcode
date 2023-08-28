namespace LeetCode;

public static class _020_ValidParentheses
{
    public static bool IsValid(string s)
    {
        if (s.Length <= 1) return false;

        var stack = new Stack<char>();

        foreach (var c in s.AsSpan())
        {
            if (c is '(' or '{' or '[')
            {
                stack.Push(c);
            }
            else if (stack.Count > 0)
            {
                var l = stack.Pop();
                if (
                    (c == '}' && l != '{') ||
                    (c == ')' && l != '(') ||
                    (c == ']' && l != '['))
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        return stack.Count == 0;
    }
}