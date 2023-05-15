namespace LeetCode;

/*
 * https://leetcode.com/problems/contains-duplicate/submissions/946234692/
 * Runtime: 193 ms - O(n)
 * Memory: 55.5 MB - 0(n) 
 */

public static class _217_ContainsDuplicate {
    public static bool ContainsDuplicate(int[] nums)
    {
        var set = new HashSet<int>();
        foreach (var t in nums)
        {
            if (set.Contains(t))
            {
                return true;
            }
            set.Add(t);
        }
        return false;
    }
}