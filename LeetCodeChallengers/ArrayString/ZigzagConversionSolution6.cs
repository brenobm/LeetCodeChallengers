using System.Text;

namespace LeetCodeChallengers.ArrayString;

/*
 * 6. Zigzag Conversion
 * 
 * The string "PAYPALISHIRING" is written in a zigzag pattern on a given number of rows like this: (you may want to display this pattern in a fixed font for better legibility)
 * P   A   H   N
 * A P L S I I G
 * Y   I   R
 * And then read line by line: "PAHNAPLSIIGYIR"
 * Write the code that will take a string and make this conversion given a number of rows:
 * string convert(string s, int numRows);
 * 
 * Example 1:
 * Input: s = "PAYPALISHIRING", numRows = 3
 * Output: "PAHNAPLSIIGYIR"
 * 
 * Example 2:
 * Input: s = "PAYPALISHIRING", numRows = 4
 * Output: "PINALSIGYAHRPI"
 * Explanation:
 * P     I    N
 * A   L S  I G
 * Y A   H R
 * P     I
 * 
 * Example 3:
 * Input: s = "A", numRows = 1
 * Output: "A"
 * 
 * Constraints:
 * 1 <= s.length <= 1000
 * s consists of English letters (lower-case and upper-case), ',' and '.'.
 * 1 <= numRows <= 1000
 */
public class ZigzagConversionSolution6
{
    public string Convert(string s, int numRows)
    {
        var matrix = new List<List<char>>();

        for (int i = 0; i < numRows; i++)
        {
            matrix.Add(new List<char>());
        }

        var index1 = 0;
        var index2 = 0;
        var isFullRow = true;
        var isGoingDow = true;

        foreach (char c in s)
        {
            while (matrix[index1].Count <= index2) 
            {
                matrix[index1].Add('\0');
            }
            matrix[index1][index2] = c;

            if (isFullRow)
            {
                index1 = isGoingDow? index1 + 1 : index1 - 1;

                if (index1 == numRows)
                {
                    isFullRow = false || numRows <= 2;
                    index2++;
                    index1 -= 2;
                    isGoingDow = !isGoingDow;
                }
                else if (index1 < 0)
                {
                    isFullRow = false || numRows <= 2;
                    index2++;
                    index1 += 2;
                    isGoingDow = !isGoingDow;
                }
            }
            else
            {
                index2++;
                index1 = isGoingDow ? index1 + 1 : index1 - 1;

                if (index1 == numRows - 1 || index1 == 0)
                {
                    isFullRow = true;
                    isGoingDow = !isGoingDow;
                }
            }
            if (index1 < 0)
                index1 = 0;
            if (index1 > numRows - 1)
                index1 = numRows - 1;

        }

        var stringBuilder = new StringBuilder();

        foreach(var list in matrix)
        {
            foreach(char c in list)
            {
                if (c != '\0')
                {
                    stringBuilder.Append(c);
                }
            }
        }

        return stringBuilder.ToString();
    }
}
