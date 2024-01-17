namespace LeetCodeChallengers.SlidingWindow;

/*
 * 76. Minimum Window Substring
 * 
 * Given two strings s and t of lengths m and n respectively, return the minimum window substring of s such that every character in t (including duplicates) is included in the window. If there is no such substring, return the empty string "".
 * The testcases will be generated such that the answer is unique.
 * 
 * Example 1:
 * Input: s = "ADOBECODEBANC", t = "ABC"
 * Output: "BANC"
 * Explanation: The minimum window substring "BANC" includes 'A', 'B', and 'C' from string t.
 * 
 * Example 2:
 * Input: s = "a", t = "a"
 * Output: "a"
 * Explanation: The entire string s is the minimum window.
 * 
 * Example 3:
 * Input: s = "a", t = "aa"
 * Output: ""
 * Explanation: Both 'a's from t must be included in the window.
 * Since the largest window of s only has one 'a', return empty string.
 * 
 * Constraints:
 * m == s.length
 * n == t.length
 * 1 <= m, n <= 105
 * s and t consist of uppercase and lowercase English letters.
 * 
 * Follow up: Could you find an algorithm that runs in O(m + n) time?
 */
public class MinimumWindowSubstringSolution76
{
    public string MinWindow(string s, string t)
    {
        if (s.Length < t.Length)
        {
            return "";
        }

        int[] sCharsCount = new int[128];
        int[] tCharsCount = new int[128];

        foreach (char c in t)
        {
            tCharsCount[c]++;
        }

        int left = 0;
        int right = 0;
        int minLeft = int.MaxValue;
        int minSize = int.MaxValue;
        int charsToMatch = t.Length;

        while (right < s.Length)
        {
            var current = s[right];

            sCharsCount[current]++;

            if (tCharsCount[current] > 0 && sCharsCount[current] <= tCharsCount[current])
            {
                charsToMatch--;
            }

            while (charsToMatch == 0)
            {
                if (right - left + 1 < minSize)
                {
                    minLeft = left;
                    minSize = right - left + 1;
                }

                current = s[left];

                sCharsCount[current]--;

                if (tCharsCount[current] > 0 && sCharsCount[current] < tCharsCount[current])
                {
                    charsToMatch++;
                }

                left++;
            }

            right++;
        }

        return minLeft == int.MaxValue ? string.Empty : s.Substring(minLeft, minSize);
    }
}
