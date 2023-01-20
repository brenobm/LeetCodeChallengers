namespace LeetCodeChallengers.DynamicProgramming;

/*
 * 5. Longest Palindromic Substring
 * 
 * Given a string s, return the longest palindromic substring in s.
 * 
 * Example 1:
 * Input: s = "babad"
 * Output: "bab"
 * Explanation: "aba" is also a valid answer.
 * 
 * Example 2:
 * Input: s = "cbbd"
 * Output: "bb"
 * 
 * Constraints:
 * 1 <= s.length <= 1000
 * s consist of only digits and English letters.
 */
public class LongestPalindromicSubstringSolution05
{
    public string LongestPalindrome(string s)
    {
        if (s.Length == 1)
            return s;

        var left = 0;
        var right = 0;

        for (int i = 0; i < s.Length; i++)
        {
            var (l1, r1) = findMaxPalindromicFromCenter(s, i, i);
            var (l2, r2) = findMaxPalindromicFromCenter(s, i, i + 1);

            if (r1 - l1 > r2 - l2)
            {
                if (r1 - l1 > right - left)
                {
                    right = r1;
                    left = l1;
                }
            }
            else
            {
                if (r2 - l2 > right - left)
                {
                    right = r2;
                    left = l2;
                }
            }

        }

        return s.Substring(left, (right - left + 1));
    }

    private Tuple<int, int> findMaxPalindromicFromCenter(string s, int left, int right)
    {
        while (left >= 0 && right < s.Length && s[left] == s[right])
        {
            left--;
            right++;
        }
        left++;
        right--;

        return new Tuple<int, int>(left, right);
    }
}
