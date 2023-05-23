namespace LeetCode;
/*
 * https://leetcode.com/problems/valid-anagram/submissions/956020137/
 * Runtime: 84 ms - O(s+t)
 * Memory: 40.7 MB - O(s+t)
 */
public static class _242_ValidAnagram {
    public static bool IsAnagram(string s, string t)
    {
        var sArr = s.ToCharArray();
        var tArr = t.ToCharArray();

        Array.Sort(sArr);
        Array.Sort(tArr);
    
        return sArr.SequenceEqual(tArr);
    } 
}