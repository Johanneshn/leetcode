namespace LeetCode;

public class _739_DailyTemperatures
{
    private readonly record struct Day(int Index, int Temperature);

    public static int[] DailyTemperatures(int[] temperatures)
    {
        var result = new int[temperatures.Length];
        var stack = new Stack<Day>();
        for (var i = 0; i < temperatures.Length; i++)
        {
            int currentTemp = temperatures[i];
            while (stack.Count > 0 &&  currentTemp >stack.Peek().Temperature)
            {
                var (stackIndex, _) = stack.Pop();
                result[stackIndex] = i - stackIndex; 
            }
            stack.Push(new Day(i, currentTemp));
        }
        return result;
    }
}