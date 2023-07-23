namespace LeetCode;
/*
 * Time: O(n)
 * Space: O(1)
 */
public static class _125_ValidPalindrome
{
    public static bool IsPalindrome(string s)
    {
        var left = 0;
        var right = s.Length - 1;

        while (left < right)
        {
            while (left < right && !char.IsLetterOrDigit(s[left])) left++; 
            while (left < right && !char.IsLetterOrDigit(s[right])) right--;

            if (char.ToLower(s[left]) != char.ToLower(s[right]))
            {
                return false;
            }
            
            left++;
            right--;
        }
        return true;
    }
}