/*
28. Find the Index of the First Occurrence in a String
Easy
Topics
conpanies icon
Companies
Given two strings needle and haystack, return the index of the first occurrence of needle in haystack, or -1 if needle is not part of haystack.

 

Example 1:

Input: haystack = "sadbutsad", needle = "sad"
Output: 0
Explanation: "sad" occurs at index 0 and 6.
The first occurrence is at index 0, so we return 0.
Example 2:

Input: haystack = "leetcode", needle = "leeto"
Output: -1
Explanation: "leeto" did not occur in "leetcode", so we return -1.
 

Constraints:

1 <= haystack.length, needle.length <= 104
haystack and needle consist of only lowercase English characters.
*/


Console.WriteLine(Solution.StrStr("sadbutsad", "sad"));
public class Solution
{
    public static int StrStr(string haystack, string needle)
    {
        if (needle.Length < 1)
            return 0;

        for (int windowStart = 0; windowStart <= haystack.Length - needle.Length; windowStart++)
        {
            for (int n = 0; n < needle.Length; n++)
            {
                if (needle[n] != haystack[windowStart + n])
                    break;
                if (n == needle.Length - 1)
                    return windowStart;
            }
        }
        return -1;
    }
}

