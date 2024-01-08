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
    private static readonly Dictionary<char, List<char>> _digitsMap = new()
    {
        { '1', new() },
        { '2', new(){ 'a', 'b', 'c' } },
        { '3', new(){ 'd', 'e', 'f' } },
        { '4', new(){ 'g', 'h', 'i' } },
        { '5', new(){ 'j', 'k', 'l' } },
        { '6', new(){ 'm', 'n', 'o' } },
        { '7', new(){ 'p', 'q', 'r', 's' } },
        { '8', new(){ 't', 'u', 'v' } },
        { '9', new(){ 'w', 'x', 'y', 'z' } },
    };

    public IList<string> LetterCombinations(string digits)
    {
        var result = new List<string>();
        return LetterCombinations(digits, 0, result);
    }

    private IList<string> LetterCombinations(string digits, int digitIndex, IList<string> oldResult)
    {
        if (digitIndex >= digits.Length)
        {
            return oldResult;
        }

        var digit = digits[digitIndex];

        var result = new List<string>();
        var letters = _digitsMap[digit];

        if (oldResult.Count == 0 && letters.Count > 0)
        {
            oldResult.Add("");
        }

        foreach (var item in oldResult)
        {
            foreach (var letter in letters)
            {
                result.Add($"{item}{letter}");
            }
        }

        return LetterCombinations(digits, digitIndex + 1, result);
    }
}