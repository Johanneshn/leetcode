namespace LeetCode;

public static class _049_GroupAnagrams
{
    public static IList<IList<string>> GroupAnagrams(string[] strs)
    {
        var dictionary = new Dictionary<string, List<string>>();
        foreach (var item in strs)
        {
            var sorted = item.ToCharArray();
            Array.Sort(sorted);

            var key = new string(sorted);
            if (dictionary.ContainsKey(key) is false)
            {
                dictionary[key] = new List<string>();
            }

            dictionary[key].Add(item);
        }

        return new List<IList<string>>(dictionary.Values);
    }
}