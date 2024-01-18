namespace LeetCodeChallengers.Hashmap;

/*
 * 242. Valid Anagram
 * 
 * Given two strings s and t, return true if t is an anagram of s, and false otherwise.
 * An Anagram is a word or phrase formed by rearranging the letters of a different word or phrase, typically using all the original letters exactly once.
 * 
 * Example 1:
 * Input: s = "anagram", t = "nagaram"
 * Output: true
 * 
 * Example 2:
 * Input: s = "rat", t = "car"
 * Output: false
 * 
 * Constraints:
 * 1 <= s.length, t.length <= 5 * 104
 * s and t consist of lowercase English letters.
 * Follow up: What if the inputs contain Unicode characters? How would you adapt your solution to such a case?
 */
public class ValidAnagramSolution242
{
    public bool IsAnagram(string s, string t)
    {
        var dic = new Dictionary<char, int>();

        foreach (char c in s)
        {
            if (!dic.ContainsKey(c))
            {
                dic.Add(c, 0);
            }
            dic[c]++;
        }

        foreach (char c in t)
        {
            if (!dic.ContainsKey(c))
            {
                return false;
            }
            dic[c]--;

            if (dic[c] == 0)
            {
                dic.Remove(c);
            }
        }

        return dic.Count == 0;
    }
}
