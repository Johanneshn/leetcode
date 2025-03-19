namespace LeetCode.UnitTest;

public class _271_EncodeAndDecodeStrings_Tests
{
    [Theory]
    [InlineData(new[] { "neet", "code", "love", "you" }, new[] { "neet", "code", "love", "you" })]
    [InlineData(new[] { "we", "say", ":", "yes" }, new[] { "we", "say", ":", "yes" })]
    public void Solution(string[] input, string[] expected)
    {
        var encoded = _271_EncodeAndDecodeStrings.Encode(input);
        var actual = _271_EncodeAndDecodeStrings.Decode(encoded);
        Assert.Equal(expected, actual);
    }
}