namespace LeetCodeChallengers.ArrayString;

/*
 * 135. Candy
 * 
 * There are n children standing in a line. Each child is assigned a rating value given in the integer array ratings.
 * 
 * You are giving candies to these children subjected to the following requirements:
 *   * Each child must have at least one candy.
 *   * Children with a higher rating get more candies than their neighbors.
 * Return the minimum number of candies you need to have to distribute the candies to the children.
 * 
 * Example 1:
 * Input: ratings = [1,0,2]
 * Output: 5
 * Explanation: You can allocate to the first, second and third child with 2, 1, 2 candies respectively.
 * 
 * Example 2:
 * Input: ratings = [1,2,2]
 * Output: 4
 * Explanation: You can allocate to the first, second and third child with 1, 2, 1 candies respectively.
 * The third child gets 1 candy because it satisfies the above two conditions.
 * 
 * Constraints:
 * n == ratings.length
 * 1 <= n <= 2 * 104
 * 0 <= ratings[i] <= 2 * 104
 */
public class CandySolution135
{
    public int Candy(int[] ratings)
    {
        if (ratings.Length < 2) 
            return ratings.Length;

        var amount = new int[ratings.Length];

        for (int i = 0; i < ratings.Length - 1; i++)
        {
            if (ratings[i] <= ratings[i + 1])
            {
                amount[i] = 1;

                if (i > 0 && ratings[i] > ratings[i - 1])
                {
                    amount[i] += amount[i - 1];
                }
            }
            else
            {
                amount[i] = 2;

                if (i > 0 && ratings[i] > ratings[i - 1])
                {
                    amount[i] = amount[i - 1] + 1;
                }
            }

            for (var j = i - 1; j >= 0 ; j--)
            {
                if (ratings[j + 1] < ratings[j] && amount[j + 1] >= amount[j])
                {
                    amount[j]++;
                }
            }
        }

        if (ratings[ratings.Length - 1] > ratings[ratings.Length - 2])
            amount[ratings.Length - 1] = amount[ratings.Length - 2] + 1;
        else
            amount[ratings.Length - 1] = 1;

        return amount.Sum();
    }
}