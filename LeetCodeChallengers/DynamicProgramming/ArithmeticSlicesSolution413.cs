namespace LeetCodeChallengers.DynamicProgramming;

/*
 * 413. Arithmetic Slices
 * 
 * An integer array is called arithmetic if it consists of at least three elements and if the difference between any two consecutive elements is the same.
 * For example, [1,3,5,7,9], [7,7,7,7], and [3,-1,-5,-9] are arithmetic sequences.
 * Given an integer array nums, return the number of arithmetic subarrays of nums.
 * A subarray is a contiguous subsequence of the array.
 * 
 * Example 1:
 * Input: nums = [1,2,3,4]
 * Output: 3
 * Explanation: We have 3 arithmetic slices in nums: [1, 2, 3], [2, 3, 4] and [1,2,3,4] itself.
 * 
 * Example 2:
 * Input: nums = [1]
 * Output: 0
 * 
 * Constraints:
 * 1 <= nums.length <= 5000
 * -1000 <= nums[i] <= 1000
 */
public class ArithmeticSlicesSolution413
{
    public int NumberOfArithmeticSlices(int[] nums)
    {
        var numSubArrays = 0;

        var diff = 0;
        var count = 1;
        for (int i = 0; i < nums.Length - 1; i++)
        {
            if (diff == nums[i + 1] - nums[i] && i > 0)
            {
                count++;
            }
            else
            {
                numSubArrays += CountSubArrays(count);
                count = 1;
                diff = nums[i + 1] - nums[i];
            }
        }

        numSubArrays += CountSubArrays(count);
        return numSubArrays;
    }

    private int CountSubArrays(int count)
    {
        var numSubArrays = 0;
        if (count >= 2)
        {
            for (int j = count - 1; j > 0; j--)
            {
                numSubArrays += j;
            }
        }
        return numSubArrays;
    }
}
