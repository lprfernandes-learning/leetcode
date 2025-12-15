/*
205. Isomorphic Strings
Easy

Given two strings s and t, determine if they are isomorphic.

Two strings s and t are isomorphic if the characters in s can be replaced to get t.

All occurrences of a character must be replaced with another character while preserving the order of characters. No two characters may map to the same character, but a character may map to itself.

 

Example 1:

Input: s = "egg", t = "add"

Output: true

Explanation:

The strings s and t can be made identical by:

Mapping 'e' to 'a'.
Mapping 'g' to 'd'.
Example 2:

Input: s = "foo", t = "bar"

Output: false

Explanation:

The strings s and t can not be made identical as 'o' needs to be mapped to both 'a' and 'r'.

Example 3:

Input: s = "paper", t = "title"

Output: true

 

Constraints:

1 <= s.length <= 5 * 104
t.length == s.length
s and t consist of any valid ascii character.
*/



Console.WriteLine(Solution.IsIsomorphic("egg", "add"));

public class Solution
{
    public static bool IsIsomorphic(string s, string t)
    {
        Dictionary<char, char> dictS = new(), dictT = new();

        for (int i = 0; i < s.Length; i++)
        {
            char si = s[i];
            char ti = t[i];
            if (!dictS.ContainsKey(si))
                dictS[si] = ti;
            if (!dictT.ContainsKey(ti))
                dictT[ti] = si;
            if (dictS[si] != ti || dictT[ti] != si)
                return false;
        }
        return true;
    }
}
