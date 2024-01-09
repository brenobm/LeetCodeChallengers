
namespace LeetCodeChallengers.RecursionBacktracking;

/*
 * 77. Combinations
 * Given two integers n and k, return all possible combinations of k numbers chosen from the range [1, n].
 * You may return the answer in any order.
 * 
 * Example 1:
 * Input: n = 4, k = 2
 * Output: [[1,2],[1,3],[1,4],[2,3],[2,4],[3,4]]
 * Explanation: There are 4 choose 2 = 6 total combinations.
 * Note that combinations are unordered, i.e., [1,2] and [2,1] are considered to be the same combination.
 * 
 * Example 2:
 * Input: n = 1, k = 1
 * Output: [[1]]
 * Explanation: There is 1 choose 1 = 1 total combination.
 * 
 * Constraints:
 * 1 <= n <= 20
 * 1 <= k <= n
 */

public class CombinationsSolution77
{
    public IList<IList<int>> Combine(int n, int k)
    {
        var result = new List<IList<int>>();

        Combine(n, k, 1, new List<int>(), result);

        return result;
    }

    private static void Combine(int n, int k, int start, List<int> combination, List<IList<int>> result)
    {
        if (combination.Count == k)
        {
            result.Add(new List<int>(combination));
            return;
        }

        for (int i = start; i <= n; i++)
        {
            combination.Add(i);
            Combine(n, k, i + 1, combination, result);
            combination.RemoveAt(combination.Count - 1);
        }
    }
}