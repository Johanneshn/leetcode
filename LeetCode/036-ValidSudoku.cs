namespace LeetCode;

public static class _036_ValidSudoku
{
    public static bool IsValidSudoku(char[][] board)
    {
        var gridSet = new HashSet<(int, int, int)>();

        for (var i = 0; i < board.Length; i++)
        {
            var rowSet = new HashSet<char>();
            var columnSet = new HashSet<char>();
            for (var j = 0; j < board.Length; j++)
            {
                var rowValue = board[i][j];
                var columnValue = board[j][i];
                
                if (rowSet.Contains(rowValue) ||
                    columnSet.Contains(columnValue) ||
                    gridSet.Contains((i / 3, j / 3, rowValue))
                   )
                {
                    return false;
                }

                if (rowValue != '.')
                {
                    rowSet.Add(rowValue);
                    gridSet.Add((i / 3, j / 3, rowValue));
                }


                if (columnValue != '.')
                {
                    columnSet.Add(columnValue);
                }
            }
        }

        return true;
    }
}