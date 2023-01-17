namespace LeetCodeChallengers.RecursionBacktracking;

/*
 * 22. Generate Parentheses
 * 
 * Given n pairs of parentheses, write a function to generate all combinations of well-formed parentheses.
 * 
 * Example 1:
 * Input: n = 3
 * Output: ["((()))","(()())","(())()","()(())","()()()"]
 * 
 * Example 2:
 * Input: n = 1
 * Output: ["()"]
 * 
 * Constraints:
 * 1 <= n <= 8
 */
public class GenerateParenthesesSolution22
{
    public IList<string> GenerateParenthesis(int n)
    {
        var result = new HashSet<string> { "" };
        return GenerateParenthesis(n, 1, result).ToList();
    }

    private HashSet<String> GenerateParenthesis(int n, int current, HashSet<string> result)
    {
        if (current > n)
            return result;

        var newResult = new HashSet<string>();
        foreach (var r in result)
        {
            newResult.Add($"(){r}");
            newResult.Add($"{r}()");
            var index = r.IndexOf(")");
            while (index >= 0)
            {
                newResult.Add($"{r.Substring(0, index)}(){r.Substring(index, r.Length - index)}");
                index = r.IndexOf(")", index + 1);
            }
        }

        return GenerateParenthesis(n, current + 1, newResult);
    }
}
