namespace LeetCodeChallengers.BreadthFirstDepthFirstSearch;

/*
 * 130. Surrounded Regions
 * 
 * Given an m x n matrix board containing 'X' and 'O', capture all regions that are 4-directionally surrounded by 'X'.
 * 
 * A region is captured by flipping all 'O's into 'X's in that surrounded region.
 * 
 *    X, X, X, X              X, X, X, X
 *    X, O, O, X      -\      X, X, X, X
 *    X, X, O, X      -/      X, X, X, X
 *    X, O, X, X              X, 0, X, X
 * 
 * Example 1:
 * Input: board = [["X","X","X","X"],["X","O","O","X"],["X","X","O","X"],["X","O","X","X"]]
 * Output: [["X","X","X","X"],["X","X","X","X"],["X","X","X","X"],["X","O","X","X"]]
 * Explanation: Notice that an 'O' should not be flipped if:
 * - It is on the border, or
 * - It is adjacent to an 'O' that should not be flipped.
 * The bottom 'O' is on the border, so it is not flipped.
 * The other three 'O' form a surrounded region, so they are flipped.
 * 
 * Example 2:
 * Input: board = [["X"]]
 * Output: [["X"]]
 * 
 * Constraints:
 * 
 * m == board.length
 * n == board[i].length
 * 1 <= m, n <= 200
 * board[i][j] is 'X' or 'O'.
 * 
 */
public class SurroundedRegionsSolution130
{
    public void Solve(char[][] board)
    {
        var visited = new HashSet<Tuple<int, int>>();

        for (int i = 0; i < board.Length; i++)
        {
            for (int j = 0; j < board[i].Length; j++)
            {
                var current = new Tuple<int, int>(i, j);

                if (board[i][j] == 'O' && !visited.Contains(current))
                {
                    var notFlip = false;
                    var stack = new Stack<Tuple<int, int>>();
                    var tempVisited = new HashSet<Tuple<int, int>>();

                    if (i != 0 && j != 0 && i != board.Length - 1 && j != board[i].Length - 1)
                    {
                        stack.Push(current);
                        tempVisited.Add(current);
                    }
                    while (stack.Count > 0)
                    {
                        var (r, c) = stack.Pop();
                        if (r == 0 || c == 0 || r == board.Length - 1 || c == board[r].Length - 1)
                        {
                            notFlip = true;
                        }
                        else
                        {
                            var top = new Tuple<int, int>(r - 1, c);
                            if (r > 0 && !visited.Contains(top) && !tempVisited.Contains(top) && board[r - 1][c] == 'O')
                            {
                                stack.Push(top);
                                tempVisited.Add(top);
                            }
                            var left = new Tuple<int, int>(r, c - 1);
                            if (c > 0 && !visited.Contains(left) && !tempVisited.Contains(left) && board[r][c - 1] == 'O')
                            {
                                stack.Push(left);
                                tempVisited.Add(left);
                            }
                            var down = new Tuple<int, int>(r + 1, c);
                            if (r > 0 && !visited.Contains(down) && !tempVisited.Contains(down) && board[r + 1][c] == 'O')
                            {
                                stack.Push(down);
                                tempVisited.Add(down);
                            }
                            var rigth = new Tuple<int, int>(r, c + 1);
                            if (c > 0 && !visited.Contains(rigth) && !tempVisited.Contains(rigth) && board[r][c + 1] == 'O')
                            {
                                stack.Push(rigth);
                                tempVisited.Add(rigth);
                            }

                        }
                    }
                    if (tempVisited.Count > 0)
                    {
                        if (notFlip)
                        {
                            visited.UnionWith(tempVisited);
                            tempVisited.Clear();
                        }

                        foreach (var (r, c) in tempVisited)
                        {
                            board[r][c] = 'X';
                        }
                    }
                }
            }
        }
    }
}
