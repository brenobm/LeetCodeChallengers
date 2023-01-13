namespace LeetCodeChallengers.RecursionBacktracking;

/*
 * 90 Subsets II
 * 
 * Given an integer array nums that may contain duplicates, return all possible subsets (the power set).
 * The solution set must not contain duplicate subsets. Return the solution in any order.
 * 
 * Example 1:
 * Input: nums = [1,2,2]
 * Output: [[],[1],[1,2],[1,2,2],[2],[2,2]]
 * 
 * Example 2:
 * Input: nums = [0]
 * Output: [[],[0]]
 * 
 * Constraints:
 * 1 <= nums.length <= 10
 * -10 <= nums[i] <= 10
*/
public class SubsetsIISolution90
{
    public IList<IList<int>> SubsetsWithDup(int[] nums)
    {
        var result = new List<IList<int>>
        {
            new List<int>()
        };
        var existingLists = new HashSet<string>();

        foreach (var num in nums)
        {
            var newSubsets = new List<IList<int>>();
            foreach (var existing in result)
            {
                var subset = new List<int>();
                subset.AddRange(existing);
                subset.Add(num);
                var subsetString = string.Join(",", subset.OrderBy(n => n));
                if (!existingLists.Contains(subsetString))
                {
                    newSubsets.Add(subset);
                    existingLists.Add(subsetString);
                }
            }
            result.AddRange(newSubsets);
        }

        return result.ToList();
    }
}
