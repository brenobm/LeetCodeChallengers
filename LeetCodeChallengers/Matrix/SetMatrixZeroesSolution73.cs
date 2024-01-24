
namespace LeetCodeChallengers.Matrix;

/*
 * 73. Set Matrix Zeroes
 * 
 * Given an m x n integer matrix matrix, if an element is 0, set its entire row and column to 0's.
 * You must do it in place.
 * 
 * Example 1:
 * Input: matrix = [[1,1,1],
 *                  [1,0,1],
 *                  [1,1,1]]
 * Output: [[1,0,1],
 *          [0,0,0],
 *          [1,0,1]]
 * 
 * Example 2:
 * Input: matrix = [[0,1,2,0],
 *                  [3,4,5,2],
 *                  [1,3,1,5]]
 * Output: [[0,0,0,0],
 *          [0,4,5,0],
 *          [0,3,1,0]]
 * 
 * Constraints:
 * m == matrix.length
 * n == matrix[0].length
 * 1 <= m, n <= 200
 * -231 <= matrix[i][j] <= 231 - 1
 * 
 * Follow up:
 * A straightforward solution using O(mn) space is probably a bad idea.
 * A simple improvement uses O(m + n) space, but still not the best solution.
 * Could you devise a constant space solution?

 */
public class SetMatrixZeroesSolution73
{
    public void SetZeroes(int[][] matrix) 
    {
        var rows = new int[matrix.Length];
        var cols = new int[matrix[0].Length];

        for (int i = 0; i < matrix.Length; i++)
        {
            for (int j = 0; j < matrix[i].Length; j++)
            {
                if (matrix[i][j] == 0)
                {
                    rows[i] = 1;
                    cols[j] = 1;
                }
            }
        }

        for (int i = 0; i < rows.Length; i++)
        {
            if (rows[i] == 1)
            {
                for (int j = 0; j < matrix[i].Length; j++)
                {
                    matrix[i][j] = 0;
                }
            }
        }

        for (int i = 0; i < cols.Length; i++)
        {
            if (cols[i] == 1)
            {
                for (int j = 0; j < matrix.Length; j++)
                {
                    matrix[j][i] = 0;
                }
            }
        }
    }
}
