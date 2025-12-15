/*
383. Ransom Note
Easy

Given two strings ransomNote and magazine, return true if ransomNote can be constructed by using the letters from magazine and false otherwise.

Each letter in magazine can only be used once in ransomNote.

 

Example 1:

Input: ransomNote = "a", magazine = "b"
Output: false
Example 2:

Input: ransomNote = "aa", magazine = "ab"
Output: false
Example 3:

Input: ransomNote = "aa", magazine = "aab"
Output: true
 

Constraints:

1 <= ransomNote.length, magazine.length <= 105
ransomNote and magazine consist of lowercase English letters.
*/


Console.WriteLine(Solution.CanConstruct("aa", "aab"));
public class Solution
{
    public static bool CanConstruct(string ransomNote, string magazine)
    {
        //get all char counts
        Dictionary<char, int> myChars = new();

        foreach (char m in magazine)
        {
            if (!myChars.ContainsKey(m))
                myChars[m] = 0;
            myChars[m]++;
        }

        foreach (char r in ransomNote)
        {
            if (!myChars.ContainsKey(r))
                return false;
            else if (myChars[r] == 1)
                myChars.Remove(r);
            else
                myChars[r]--;
        }
        return true;
    }
}