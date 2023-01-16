namespace LeetCodeChallengers.RecursionBacktracking;

/*
 * 39. Combination Sum
 * Given an array of distinct integers candidates and a target integer target, return a list of all unique combinations of candidates where the chosen numbers sum to target. You may return the combinations in any order.
 * 
 * The same number may be chosen from candidates an unlimited number of times. Two combinations are unique if the 
 * frequency of at least one of the chosen numbers is different.
 * The test cases are generated such that the number of unique combinations that sum up to target is less than 150 combinations for the given input.
 * 
 * Example 1:
 * Input: candidates = [2,3,6,7], target = 7
 * Output: [[2,2,3],[7]]
 * Explanation:
 * 2 and 3 are candidates, and 2 + 2 + 3 = 7. Note that 2 can be used multiple times. 7 is a candidate, and 7 = 7.
 * These are the only two combinations.
 * 
 * Example 2:
 * Input: candidates = [2,3,5], target = 8
 * Output: [[2,2,2,2],[2,3,3],[3,5]]
 * 
 * Example 3:

Input: candidates = [2], target = 1
Output: []
 */
public class CombinationSumSolution39
{
    public IList<IList<int>> CombinationSum(int[] candidates, int target)
    {
        Array.Sort(candidates);
        var result = new List<IList<int>>();
        var currentList = new List<int>();
        CombinationSum(candidates, target, result, currentList, 0, 0);
        return result;
    }

    private void CombinationSum(int[] candidates, int target, IList<IList<int>> result, IList<int> currentList, int start, int sum)
    {
        if (sum > target)
            return;
        if (sum == target)
        {
            result.Add(new List<int>(currentList));
            return;
        }
        for (int i = start; i < candidates.Length; i++)
        {
            currentList.Add(candidates[i]);
            sum += candidates[i];
            CombinationSum(candidates, target, result, currentList, i, sum);
            sum -= candidates[i];
            currentList.RemoveAt(currentList.Count - 1);
        }
    }
}
