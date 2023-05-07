namespace LeetCode;

/*
 * https://leetcode.com/problems/contains-duplicate/submissions/946234692/
 * Runtime: 193 ms (beats 89.1%)
 * Memory: 55.5 MB (beats 12.71%) 
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