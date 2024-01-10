namespace LeetCodeChallengers.Matrix;

/*
 * 289. Game of Life
 * 
 * According to Wikipedia's article: "The Game of Life, also known simply as Life, is a cellular automaton devised by the British mathematician John Horton Conway in 1970."
 * 
 * The board is made up of an m x n grid of cells, where each cell has an initial state: live (represented by a 1) or dead (represented by a 0). Each cell interacts with its eight neighbors (horizontal, vertical, diagonal) using the following four rules (taken from the above Wikipedia article):
 * 1. Any live cell with fewer than two live neighbors dies as if caused by under-population.
 * 2. Any live cell with two or three live neighbors lives on to the next generation.
 * 3. Any live cell with more than three live neighbors dies, as if by over-population.
 * 4. Any dead cell with exactly three live neighbors becomes a live cell, as if by reproduction.
 * 5. The next state is created by applying the above rules simultaneously to every cell in the current state, where births and deaths occur simultaneously. Given the current state of the m x n grid board, return the next state.
 * 
 * Example 1:
 * Input: board = [ [0,1,0],
 *                  [0,0,1],
 *                  [1,1,1],
 *                  [0,0,0] ]
 * Output:        [ [0,0,0],
 *                  [1,0,1],
 *                  [0,1,1],
 *                  [0,1,0] ]
 * 
 * Example 2:
 * Input: board = [ [1,1],
 *                  [1,0] ]
 * Output:        [ [1,1],
 *                  [1,1] ]
 * 
 * Constraints:
 * m == board.length
 * n == board[i].length
 * 1 <= m, n <= 25
 * board[i][j] is 0 or 1.
 * 
 * Follow up:
 * Could you solve it in-place? Remember that the board needs to be updated simultaneously: You cannot update some cells first and then use their updated values to update other cells.
 * In this question, we represent the board using a 2D array. In principle, the board is infinite, which would cause problems when the active area encroaches upon the border of the array (i.e., live cells reach the border). How would you address these problems?
 */
public class GameOfLifeSolution289
{
    public void GameOfLife(int[][] board)
    {
        var tmp = new int[board.Length][];
        for (int i = 0; i < board.Length; i++)
        {
            tmp[i] = new int[board[i].Length];

            for (int j = 0; j < board[i].Length; j++)
            {
                tmp[i][j] = board[i][j];
            }
        }

        for (int i = 0; i < board.Length; i++)
        {
            for (int j = 0; j < board[i].Length; j++)
            {
                board[i][j] = VerifyCellStatus(i, j, tmp);
            }
        }
    }

    private static int VerifyCellStatus(int i, int j, int[][] matrix)
    {
        var livingNeighbors = 0;

        var isLivingCell = matrix[i][j] == 1;

        var rowSize = matrix.Length;
        var colSize = matrix[0].Length;

        if (i > 0)
        {
            if (j > 0)
            {
                livingNeighbors += matrix[i - 1][j - 1];
            }   
            livingNeighbors += matrix[i - 1][j];
            if (j < colSize - 1)
            {
                livingNeighbors += matrix[i - 1][j + 1];
            }
        }

        if (i < rowSize - 1)
        {
            if (j > 0)
            {
                livingNeighbors += matrix[i + 1][j - 1];
            }
            livingNeighbors += matrix[i + 1][j];
            if (j < colSize - 1)
            {
                livingNeighbors += matrix[i + 1][j + 1];
            }
        }

        if (j > 0)
        {
            livingNeighbors += matrix[i][j - 1];
        }

        if (j < colSize - 1)
        {
            livingNeighbors += matrix[i][j + 1];
        }

        if (isLivingCell && livingNeighbors < 2)
        {
            return 0;
        }
        if (isLivingCell && (livingNeighbors == 2 || livingNeighbors == 3)) 
        {
            return 1;
        }
        if (isLivingCell && livingNeighbors > 3)
        {
            return 0;
        }
        if (!isLivingCell && livingNeighbors == 3)
        {
            return 1;
        }

        return 0;
    }
}
