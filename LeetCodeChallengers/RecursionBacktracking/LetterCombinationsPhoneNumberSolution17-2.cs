using System.Diagnostics.Metrics;
using System.Text;

namespace LeetCodeChallengers.RecursionBacktracking;

/*
 * 17. Letter Combinations of a Phone Number
 * 
 * 2 -> a, b,c
 * 3 -> d, e, f
 * 4 -> g, h i
 * 5 -> j, k, l
 * 6 -> m, n. o
 * 7 -> p, q, r, s
 * 8 -> t, u, v
 * 9 -> w, x, y, z
 * 
 * Given a string containing digits from 2-9 inclusive, return all possible letter combinations that the number could represent. Return the answer in any order.
 * A mapping of digits to letters (just like on the telephone buttons) is given below. Note that 1 does not map to any letters.
 * 
 * Example 1:
 * Input: digits = "23"
 * Output: ["ad","ae","af","bd","be","bf","cd","ce","cf"]
 * 
 * Example 2:
 * Input: digits = ""
 * Output: []
 * 
 * Example 3:
 * Input: digits = "2"
 * Output: ["a","b","c"]
 * 
 * Constraints:
 * 0 <= digits.length <= 4
 * digits[i] is a digit in the range ['2', '9'].
 * 
 */
public class LetterCombinationsPhoneNumberSolution17_2
{
    private static readonly Dictionary<char, char[]> _digitsMap = new()
    {
        { '1', [] },
        { '2', [ 'a', 'b', 'c' ] },
        { '3', [ 'd', 'e', 'f' ] },
        { '4', [ 'g', 'h', 'i' ] },
        { '5', [ 'j', 'k', 'l' ] },
        { '6', [ 'm', 'n', 'o' ] },
        { '7', [ 'p', 'q', 'r', 's' ] },
        { '8', [ 't', 'u', 'v' ] },
        { '9', [ 'w', 'x', 'y', 'z' ] },
    };

    public IList<string> LetterCombinations(string digits)
    {
        var result = new List<StringBuilder>();

        for (int digitIndex = 0; digitIndex < digits.Length; digitIndex++)
        {
            var letters = _digitsMap[digits[digitIndex]];

            if (letters.Length == 0)
            {
                continue;
            }

            if (result.Count == 0)
            {
                result.Add(new StringBuilder());
            }

            var tempList = new List<StringBuilder>();

            while (result.Count != 0)
            {
                var item = result[0];
                result.RemoveAt(0);
                for (var index = 0; index < letters.Length; index++)
                {
                    if (index == letters.Length - 1)
                    {
                        tempList.Add(item.Append(letters[index]));
                    }
                    else
                    {
                        tempList.Add(new StringBuilder().Append(item).Append(letters[index]));
                    }
                }
            }

            result = tempList;
        }

        return result.Select(sb => sb.ToString()).ToList();
    }
}