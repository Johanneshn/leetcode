namespace LeetCode;
/*
 * Time: O(n)
 * Space:  O(1)
 */
public static class _167_TwoSumIIInputArrayIsSorted
{
    public static int[] TwoSum(int[] numbers, int target)
    {
        var left = 0;
        var right = numbers.Length - 1;

        while (left <= right)
        {
            var valueToCheck = numbers[left] + numbers[right];
            if (valueToCheck == target)
            {
                return new[] { left + 1, right + 1 };
            }

            if (valueToCheck > target)
            {
                right--;
            }
            else if (valueToCheck < target)
            {
                left++;
            }
        }
        return Array.Empty<int>();
    }
}