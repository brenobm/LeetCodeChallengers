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
public class LetterCombinationsPhoneNumberSolution17
{
    private Dictionary<char, string[]> NumberMapping = new Dictionary<char, string[]> {
        { '2', new string[] { "a", "b", "c" } },
        { '3', new string[] { "d", "e", "f" } },
        { '4', new string[] { "g", "h", "i" } },
        { '5', new string[] { "j", "k", "l" } },
        { '6', new string[] { "m", "n", "o" } },
        { '7', new string[] { "p", "q", "r", "s" } },
        { '8', new string[] { "t", "u", "v" } },
        { '9', new string[] { "w", "x", "y", "z" } }
    };

    public IList<string> LetterCombinations(string digits)
    {
        return Combinations(digits, 0, new List<StringBuilder>()).Select(sb => sb.ToString()).ToList();
    }

    private List<StringBuilder> Combinations(string digits, int index, List<StringBuilder> result)
    {
        if (index >= digits.Length)
            return result;

        var number = digits[index];
        var newResult = new List<StringBuilder>();
        for (int i = 0; i < NumberMapping[number].Length; i++)
        {
            if (result.Count() == 0)
            {
                var newCombination = new StringBuilder();
                newCombination.Append(NumberMapping[number][i]);
                newResult.Add(newCombination);
            }
            else
            {
                foreach (var combination in result)
                {
                    var newCombination = new StringBuilder(combination.Length);
                    newCombination.Append(combination);
                    newCombination.Append(NumberMapping[number][i]);
                    newResult.Add(newCombination);
                }
            }
        }
        return Combinations(digits, index + 1, newResult);
    }
}
