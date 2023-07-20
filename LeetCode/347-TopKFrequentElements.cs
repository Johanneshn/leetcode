namespace LeetCode;

public static class _347_TopKFrequentElements
{
    public static int[] TopKFrequent(int[] nums, int k)
    {
        var dic = new Dictionary<int, int>();
        foreach (var n in nums)
        {
            if (dic.ContainsKey(n))
            {
                dic[n]++;
            }
            else
            {
                dic[n] = 1;
            }
        }

        var sortedList = dic.OrderByDescending(x => x.Value).ToList();
        var result = new int[k];
        for (var i = 0; i < k; i++)
        {
            result[i] = sortedList[i].Key;
        }

        return result;
    }
}