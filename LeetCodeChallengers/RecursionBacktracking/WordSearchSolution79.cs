namespace LeetCodeChallengers.RecursionBacktracking;

/* 
 * 79. Word Search
 * 
 * Given an m x n grid of characters board and a string word, return true if word exists in the grid.
 * The word can be constructed from letters of sequentially adjacent cells, where adjacent cells are horizontally or vertically neighboring. The same letter cell may not be used more than once.
 * 
 * Example 1:
 * Input: board = [["A","B","C","E"],["S","F","C","S"],["A","D","E","E"]], word = "ABCCED"
 * Output: true
 * 
 * Example 2:
 * Input: board = [["A","B","C","E"],["S","F","C","S"],["A","D","E","E"]], word = "SEE"
 * Output: true
 * 
 * Example 3:
 * Input: board = [["A","B","C","E"],["S","F","C","S"],["A","D","E","E"]], word = "ABCB"
 * Output: false
 */
public class WordSearchSolution79
{
    public bool Exist(char[][] board, string word)
    {
        for (int i = 0; i < board.Length; i++)
        {
            for (int j = 0; j < board[i].Length; j++)
            {
                if (board[i][j] == word[0])
                {
                    if (SearchWord(board, word, i, j))
                        return true;
                }

            }
        }
        return false;
    }

    private bool SearchWord(char[][] board, string word, int r, int c)
    {
        var visited = new HashSet<string>();
        var levels = new List<string>();
        var stack = new Stack<Tuple<int, int, int>>();
        stack.Push(new Tuple<int, int, int>(r, c, 0));

        while (stack.Count > 0)
        {
            var (i, j, counter) = stack.Pop();
            if (counter == word.Length - 1)
                return true;

            if (counter < levels.Count())
            {
                for (int k = levels.Count() - 1; k >= counter; k--)
                {
                    visited.Remove(levels[k]);
                    levels.RemoveAt(k);
                }
            }
            levels.Add($"{i},{j}");
            visited.Add($"{i},{j}");

            // Upper
            if (i > 0 && board[i - 1][j] == word[counter + 1] && !visited.Contains($"{i - 1},{j}"))
            {
                stack.Push(new Tuple<int, int, int>(i - 1, j, counter + 1));
            }
            // Down
            if (i < board.Length - 1 && board[i + 1][j] == word[counter + 1] && !visited.Contains($"{i + 1},{j}"))
            {
                stack.Push(new Tuple<int, int, int>(i + 1, j, counter + 1));
            }
            // Left
            if (j > 0 && board[i][j - 1] == word[counter + 1] && !visited.Contains($"{i},{j - 1}"))
            {
                stack.Push(new Tuple<int, int, int>(i, j - 1, counter + 1));
            }
            // Rigth
            if (j < board[i].Length - 1 && board[i][j + 1] == word[counter + 1] && !visited.Contains($"{i},{j + 1}"))
            {
                stack.Push(new Tuple<int, int, int>(i, j + 1, counter + 1));
            }
        }

        return false;
    }

}
