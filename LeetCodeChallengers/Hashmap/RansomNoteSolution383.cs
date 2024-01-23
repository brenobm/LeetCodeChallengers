namespace LeetCodeChallengers.Hashmap;

/*
 * 383. Ransom Note
 * 
 * Given two strings ransomNote and magazine, return true if ransomNote can be constructed by using the letters from magazine and false otherwise.
 * Each letter in magazine can only be used once in ransomNote.
 * 
 * Example 1:
 * Input: ransomNote = "a", magazine = "b"
 * Output: false
 * 
 * Example 2:
 * Input: ransomNote = "aa", magazine = "ab"
 * Output: false
 * 
 * Example 3:
 * Input: ransomNote = "aa", magazine = "aab"
 * Output: true
 * 
 * Constraints:
 * 1 <= ransomNote.length, magazine.length <= 105
 * ransomNote and magazine consist of lowercase English letters.
 */
public class RansomNoteSolution383
{
    public bool CanConstruct(string ransomNote, string magazine)
    {
        var magazineLetters = new Dictionary<char, int>();
        
        foreach (var letter in magazine)
        {
            if (!magazineLetters.ContainsKey(letter))
            {
                magazineLetters.Add(letter, 1);
            }
            else
            {
                magazineLetters[letter]++;
            }
        }

        foreach (var letter in ransomNote)
        {
            if (!magazineLetters.ContainsKey(letter) || magazineLetters[letter] == 0)
            {
                return false;
            }

            magazineLetters[letter]--;
        }

        return true;
    }
}
