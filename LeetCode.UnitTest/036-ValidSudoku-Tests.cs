namespace LeetCode.UnitTest;

public class _036_ValidSudoku_Tests
{
    [Theory]
    [MemberData(nameof(Case1))]
    [MemberData(nameof(Case2))]
    [MemberData(nameof(Case3))]
    [MemberData(nameof(Case4))]
    [MemberData(nameof(Case5))]
    public void Solution(char[][] board, bool expected)
    {
        var actual = _036_ValidSudoku.IsValidSudoku(board);
        Assert.Equal(expected, actual);
    }

    public static readonly TheoryData<char[][], bool> Case1 =
        new()
        {
            {
                new[]
                {
                    new[] { '5', '3', '.', '.', '7', '.', '.', '.', '.' },
                    new[] { '6', '.', '.', '1', '9', '5', '.', '.', '.' },
                    new[] { '.', '9', '8', '.', '.', '.', '.', '6', '.' },
                    new[] { '8', '.', '.', '.', '6', '.', '.', '.', '3' },
                    new[] { '4', '.', '.', '8', '.', '3', '.', '.', '1' },
                    new[] { '7', '.', '.', '.', '2', '.', '.', '.', '6' },
                    new[] { '.', '6', '.', '.', '.', '.', '2', '8', '.' },
                    new[] { '.', '.', '.', '4', '1', '9', '.', '.', '5' },
                    new[] { '.', '.', '.', '.', '8', '.', '.', '7', '9' }
                },
                true
            }
        };


    public static readonly TheoryData<char[][], bool> Case2 =
        new()
        {
            {
                new[]
                {
                    new[] { '8', '3', '.', '.', '7', '.', '.', '.', '.' },
                    new[] { '6', '.', '.', '1', '9', '5', '.', '.', '.' },
                    new[] { '.', '9', '8', '.', '.', '.', '.', '6', '.' },
                    new[] { '8', '.', '.', '.', '6', '.', '.', '.', '3' },
                    new[] { '4', '.', '.', '8', '.', '3', '.', '.', '1' },
                    new[] { '7', '.', '.', '.', '2', '.', '.', '.', '6' },
                    new[] { '.', '6', '.', '.', '.', '.', '2', '8', '.' },
                    new[] { '.', '.', '.', '4', '1', '9', '.', '.', '5' },
                    new[] { '.', '.', '.', '.', '8', '.', '.', '7', '9' },
                },
                false
            }
        };

    public static readonly TheoryData<char[][], bool> Case3 =
        new()
        {
            {
                new[]
                {
                    new[] { '1', '2', '2' },
                    new[] { '2', '5', '7' },
                    new[] { '3', '6', '9' },
                },
                false
            }
        };

    public static readonly TheoryData<char[][], bool> Case4 =
        new()
        {
            {
                new[]
                {
                    new[] { '1', '2', '3' },
                    new[] { '1', '5', '7' },
                    new[] { '3', '6', '9' },
                },
                false
            }
        };


    public static readonly TheoryData<char[][], bool> Case5 =
        new()
        {
            {
                new[]
                {
                    new[] { '5', '3', '.', '.', '7', '.', '.', '.', '.' },
                    new[] { '6', '.', '.', '1', '9', '5', '.', '.', '.' },
                    new[] { '.', '9', '8', '.', '.', '.', '.', '6', '.' },
                    new[] { '8', '.', '.', '.', '6', '.', '.', '.', '3' },
                    new[] { '4', '.', '.', '8', '.', '3', '.', '.', '1' },
                    new[] { '7', '.', '.', '.', '2', '.', '.', '.', '6' },
                    new[] { '.', '6', '.', '.', '.', '.', '2', '8', '.' },
                    new[] { '.', '.', '.', '4', '1', '9', '.', '.', '5' },
                    new[] { '.', '.', '.', '.', '8', '.', '.', '7', '9' }
                },
                true
            }
        };
}