using System.Text;

namespace LeetCodeChallengers.ArrayString;

/*
 * 12. Integer to Roman
 * 
 * Roman numerals are represented by seven different symbols: I, V, X, L, C, D and M.
 * Symbol       Value
 * I             1
 * V             5
 * X             10
 * L             50
 * C             100
 * D             500
 * M             1000
 * 
 * For example, 2 is written as II in Roman numeral, just two one's added together. 12 is written as XII, which is simply X + II. The number 27 is written as XXVII, which is XX + V + II.
 * Roman numerals are usually written largest to smallest from left to right. However, the numeral for four is not IIII. Instead, the number four is written as IV. Because the one is before the five we subtract it making four. The same principle applies to the number nine, which is written as IX. There are six instances where subtraction is used:
 * I can be placed before V (5) and X (10) to make 4 and 9. 
 * X can be placed before L (50) and C (100) to make 40 and 90. 
 * C can be placed before D (500) and M (1000) to make 400 and 900.
 * Given an integer, convert it to a roman numeral.
 * 
 * Example 1:
 * Input: num = 3
 * Output: "III"
 * Explanation: 3 is represented as 3 ones.
 * 
 * Example 2:
 * Input: num = 58
 * Output: "LVIII"
 * Explanation: L = 50, V = 5, III = 3.
 * 
 * Example 3:
 * Input: num = 1994
 * Output: "MCMXCIV"
 * Explanation: M = 1000, CM = 900, XC = 90 and IV = 4.
 * 
 * Constraints:
 * 1 <= num <= 3999
 */
public class IntegerToRomanSolution12
{
    private static readonly char[][] chars =
        [['I', 'V'], ['X', 'L'], ['C', 'D'], ['M']];

    public string IntToRoman(int num)
    {
        var roman = new StringBuilder();

        var (newNum, part) = GetPart(num, 3);
        roman.Append(part);
        (newNum, part) = GetPart(newNum, 2);
        roman.Append(part);
        (newNum, part) = GetPart(newNum, 1);
        roman.Append(part);
        (_, part) = GetPart(newNum, 0);
        roman.Append(part);

        return roman.ToString();
    }

    private (int newNum, string part) GetPart(int num, int @decimal)
    {
        var digit = num / (int)Math.Pow(10, @decimal);

        if (digit == 0)
        {
            return (num, "");
        }

        var newNum = num % (int)Math.Pow(10, @decimal);

        var p1 = digit % 5;
        var p2 = digit / 5;

        var part = GetPart(p1, p2, @decimal);

        return (newNum, part);
    }

    private string GetPart(int p1, int p2, int @decimal)
    {
        var @char = chars[@decimal][p2];

        if (p1 < 4)
        {
            if (p2 == 0) 
            {
                return new string(@char, p1);
            }
            else
            {
                return $"{@char}{(p1 == 0 ? string.Empty : new string(chars[@decimal][p2 - 1], p1))}";
            }
            
        } 
        else 
        {
            if (p2 == 1)
            {
                return $"{chars[@decimal][p2 - 1]}{chars[@decimal + 1][p2 - 1]}";
            }
            else
            {
                return $"{@char}{chars[@decimal][p2 + 1]}";
            }            
        }
    }
}
