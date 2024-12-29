namespace LeetCode;

/*
 * Time: O(n)
 * Space: O(n)
 */
public class _150_EvaluateReversePolishNotation {
    public static int EvalRPN(string[] tokens)
    {
        var stack = new Stack<int>();

        foreach (var token in tokens)
        {
            if (int.TryParse(token, out var number))
            {
                stack.Push(number);
            }
            else
            {
                var first = stack.Pop();
                var second = stack.Pop();

                switch (token)
                {
                    case "+":
                        stack.Push(second + first);
                        break;
                    case "-":
                        stack.Push(second - first);
                        break;
                    case "*":
                        stack.Push(second * first);
                        break;
                    case "/":
                        stack.Push(second / first);
                        break;
                }
            }
        }
        return stack.Pop();
    }
}