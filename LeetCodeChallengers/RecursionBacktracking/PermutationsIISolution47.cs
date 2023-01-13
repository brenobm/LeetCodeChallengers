namespace LeetCodeChallengers.RecursionBacktracking;

/*
 * 47 Permutations II
 * 
 * Given a collection of numbers, nums, that might contain duplicates, return all possible unique permutations in any order.
 * 
 * Example 1:
 * Input: nums = [1,1,2]
 * Output:
 * [[1,1,2],
 * [1,2,1],
 * [2,1,1]]
 * 
 * Example 2:
 * Input: nums = [1,2,3]
 * Output: [[1,2,3],[1,3,2],[2,1,3],[2,3,1],[3,1,2],[3,2,1]]
 * 
 * Constraints:
 * 1 <= nums.length <= 8
 * -10 <= nums[i] <= 10
*/
public class PermutationsIISolution47
{
    public IList<IList<int>> PermuteUnique(int[] nums)
    {
        var result = new List<IList<int>>();
        var existingPermutations = new HashSet<string>();
        foreach (var num in nums)
        {
            if (result.Count > 0)
            {
                var newPermutations = new List<IList<int>>();
                foreach (var permutation in result)
                {
                    for (int i = 0; i <= permutation.Count; i++)
                    {
                        var newPermutation = new List<int>();
                        newPermutation.AddRange(permutation);
                        newPermutation.Insert(i, num);
                        var permutationString = string.Join(",", newPermutation);
                        if (!existingPermutations.Contains(permutationString))
                        {
                            newPermutations.Add(newPermutation);
                            existingPermutations.Add(permutationString);
                        }
                    }
                }
                result = newPermutations;

            }
            else
            {
                result.Add(new List<int> { num });
            }
        }

        return result;
    }
}
