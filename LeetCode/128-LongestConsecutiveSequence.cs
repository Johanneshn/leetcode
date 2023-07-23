namespace LeetCode;
/*
 * Time: O(n)
 * Space:  O(n)
 */
public static class _128_LongestConsecutiveSequence {
    public static  int LongestConsecutive(int[] nums)
    {
        var result = 0;
        var hash = new HashSet<int>();
        
        foreach (var num in nums)
        {
            hash.Add(num);
        }

        foreach (var val in hash)
        {
            if (hash.TryGetValue(val - 1, out _)) continue;
            var longestStreak = 1;
            var current = val;
            while (true)
            {
                current++;
                if (hash.TryGetValue(current, out _) is false)
                {
                    result = Math.Max(longestStreak, result);
                    break;
                }

                longestStreak++;
            }
        }


        return result;
    } 
}