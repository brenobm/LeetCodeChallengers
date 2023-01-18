namespace LeetCodeChallengers.DynamicProgramming;

/*
 * 213. House Robber II
 * 
 * You are a professional robber planning to rob houses along a street. Each house has a certain amount of money stashed. All houses at this place are arranged in a circle. That means the first house is the neighbor of the last one. Meanwhile, adjacent houses have a security system connected, and it will automatically contact the police if two adjacent houses were broken into on the same night.
 * Given an integer array nums representing the amount of money of each house, return the maximum amount of money you can rob tonight without alerting the police.
 * 
 * Example 1:
 * Input: nums = [2,3,2]
 * Output: 3
 * Explanation: You cannot rob house 1 (money = 2) and then rob house 3 (money = 2), because they are adjacent houses.
 * 
 * Example 2:
 * Input: nums = [1,2,3,1]
 * Output: 4
 * Explanation: Rob house 1 (money = 1) and then rob house 3 (money = 3).
 * Total amount you can rob = 1 + 3 = 4.
 * 
 * Example 3:
 * Input: nums = [1,2,3]
 * Output: 3
 * 
 * Constraints:
 * 1 <= nums.length <= 100
 * 0 <= nums[i] <= 1000
 */
public class HouseRobberIISolution213
{
    public int Rob(int[] nums)
    {
        if (nums.Length == 1)
            return nums[0];
        if (nums.Length == 2)
        {
            return Math.Max(nums[0], nums[1]);
        }

        return Math.Max(
            FindMaxEarning(nums, 0, nums.Length - 1),
            FindMaxEarning(nums, 1, nums.Length)
        );
    }

    private int FindMaxEarning(int[] nums, int start, int end)
    {
        var dp = new int[2];
        dp[0] = nums[start];
        dp[1] = Math.Max(nums[start + 1], nums[start]);

        for (int i = start + 2; i < end; i++)
        {
            var tmp = dp[1];
            dp[1] = Math.Max(dp[1], dp[0] + nums[i]);
            dp[0] = tmp;
        }

        return dp[1];
    }
}
