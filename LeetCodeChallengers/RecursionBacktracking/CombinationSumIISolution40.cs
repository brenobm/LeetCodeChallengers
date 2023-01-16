namespace LeetCodeChallengers.RecursionBacktracking;

/*
 * 40. Combination Sum II
 * 
 * Given a collection of candidate numbers (candidates) and a target number (target), find all unique combinations in candidates where the candidate numbers sum to target.
 * Each number in candidates may only be used once in the combination.
 * Note: The solution set must not contain duplicate combinations.
 * 
 * Example 1:
 * Input: candidates = [10,1,2,7,6,1,5], target = 8
 * Output: [[1,1,6], [1,2,5], [1,7], [2,6]]
 * 
 * Example 2:
 * Input: candidates = [2,5,2,1,2], target = 5
 * Output: [[1,2,2],[5]]
 * 
 * Constraints:
 * 1 <= candidates.length <= 100
 * 1 <= candidates[i] <= 50
 * 1 <= target <= 30
*/

public class CombinationSumIISolution40
{
    public IList<IList<int>> CombinationSum2(int[] candidates, int target)
    {
        var result = new List<IList<int>>();
        var list = new List<int>();
        var frequency = new Dictionary<int, int>();
        foreach (var c in candidates)
        {
            if (frequency.ContainsKey(c))
                frequency[c]++;
            else
                frequency.Add(c, 1);
        }
        CombinationSum2(target, result, list, 0, frequency);
        return result;
    }

    private void CombinationSum2(int target, IList<IList<int>> result, IList<int> list, int sum, Dictionary<int, int> frequency)
    {
        foreach (var candidate in frequency.Keys)
        {
            var remainItems = frequency[candidate];

            if (sum > target || remainItems == 0)
                return;

            list.Add(candidate);
            sum += candidate;
            frequency[candidate]--;

            if (sum == target)
            {
                var newResult = list.OrderBy(c => c).ToList();
                if (IsUnique(result, newResult))
                {
                    result.Add(newResult);
                }
            }

            CombinationSum2(target, result, list, sum, frequency);
            list.RemoveAt(list.Count - 1);
            sum -= candidate;
            frequency[candidate]++;
        }
    }

    private bool IsUnique(IList<IList<int>> listOfLists, IList<int> list)
    {
        foreach (var l in listOfLists)
        {
            if (Enumerable.SequenceEqual(l, list))
                return false;
        }

        return true;
    }
}
