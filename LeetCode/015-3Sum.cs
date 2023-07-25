namespace LeetCode;
/*
 * Time: O(n^2)
 * Space: O(1)
 */
public static class _015_3Sum
{
    public static IList<IList<int>> ThreeSum(int[] nums)
    {
        Array.Sort(nums);
        var result = new List<int[]>();
        foreach (var (value, index) in nums.Select(((value, index) => (value, index))))
        {
            if (index > 0 && value == nums[index - 1]) continue;

            var left = index + 1;
            var right = nums.Length - 1;
            while (left < right)
            {
                var sum = value + nums[left] + nums[right];
                if (sum > 0)
                {
                    right--;
                }
                else if (sum < 0)
                    left++;
                else
                {
                    result.Add(new[] { value, nums[left], nums[right] });
                    left++;
                    while (nums[left] == nums[left - 1] && left < right)
                    {
                        left++;
                    }
                }
            }
        }

        return new List<IList<int>>(result);
    }
}