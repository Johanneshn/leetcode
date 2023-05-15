namespace LeetCode;

/*
 * https://leetcode.com/problems/two-sum/submissions/946227379/
 * Runtime: 147 ms - O(n)
 * Memory: 45.5 MB - O(n)
 */

public static class _001_TwoSum {
    public static int[] TwoSum(int[] nums, int target)
    {
        var dic = new Dictionary<int, int>();
        for (int i = 0; i < nums.Length; i++)
        {
            var diff = target - nums[i];
            if (dic.TryGetValue(diff, out var foundIndex))
            {
                return new[] {  foundIndex, i };
            }
            dic[nums[i]] = i;
        }
        return Array.Empty<int>();
    }
}