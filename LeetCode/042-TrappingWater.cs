namespace LeetCode;
/*
 * https://leetcode.com/problems/trapping-rain-water/submissions/1379180606/
 * Runtime: 92 ms - O(n)
 * Memory: 43.13 MB - O(1)
 */
public static class _042_TrappingWater {
    public static int Trap(int[] height)
    {
        var l = 0;
        var r = height.Length - 1;
        var leftMax = height[l];
        var rightMax = height[r];
        var res = 0;

        while (l < r)
        {
            if (leftMax < rightMax)
            {
                l++;
                leftMax = Math.Max(leftMax, height[l]);
                res += leftMax - height[l];
            }
            else
            {
                r--;
                rightMax = Math.Max(rightMax, height[r]);
                res += rightMax - height[r];
            }
        }

        return res;
    } 
}