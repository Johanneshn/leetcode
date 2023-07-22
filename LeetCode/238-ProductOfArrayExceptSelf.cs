namespace LeetCode;

public class _238_ProductOfArrayExceptSelf
{
    public static int[] ProductExceptSelf(int[] nums)
    {
        var res = new int[nums.Length];
        var prefix = 1;
        for (var i = 0; i < nums.Length; i++)
        {
            res[i] = prefix;
            prefix *= nums[i];
        }

        var suffix = 1;
        for (var i = nums.Length - 1; i >= 0; i--)
        {
            res[i] *= suffix;
            suffix *= nums[i];
        }

        return res;
    }
}