using System.Runtime.InteropServices.JavaScript;

namespace LeetCode;

public class _271_EncodeAndDecodeStrings {
    public static string Encode(IList<string> strs)
    {
        return strs.Aggregate("", (current, str) => current + $"{str.Length}#{str}");
    }

    public static List<string> Decode(string s)
    {
        var result = new List<string>();
        var span = s.AsSpan();
        const char delimiter = '#';

        var i = 0;
        while (i < span.Length)
        {
            var start = i;
            while (i < span.Length && span[i] != delimiter)
            {
                i++;
            }

            if (i == span.Length) break;

            var length = int.Parse(span.Slice(start, i - start));
            i++;
            result.Add(span.Slice(i, length).ToString());
            i += length;
        }

        return result;
    }
}