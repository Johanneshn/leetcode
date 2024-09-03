namespace LeetCode;

/*
 * https://leetcode.com/problems/container-with-most-water/submissions/1378121667/ 
 * Runtime: 240 ms - O(n)
 * Memory: 62.17 MB - O(1)
 */
public static class _011_ContainerWithMostWater {
    public static int MaxArea(int[] height)
    {
        var lPointer = 0;
        var rPointer = height.Length - 1;

        var maxArea = 0;
        while (lPointer < rPointer)
        {
            var lowestHeight = Math.Min(height[lPointer], height[rPointer]);
            var distance = rPointer - lPointer;
            maxArea = Math.Max(distance * lowestHeight, maxArea);
            
            if (height[lPointer] <= height[rPointer])
            {
                lPointer++;
            }
            else
            {
                rPointer--;
            }
        }
        return maxArea;
    } 
    
}