namespace LeetCode;

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