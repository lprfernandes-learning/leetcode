/*
14. Longest Common Prefix
Easy
Topics (Array, String, Trie)

Write a function to find the longest common prefix string amongst an array of strings.

If there is no common prefix, return an empty string "".


Example 1:

Input: strs = ["flower","flow","flight"]
Output: "fl"
Example 2:

Input: strs = ["dog","racecar","car"]
Output: ""
Explanation: There is no common prefix among the input strings.
 

Constraints:

1 <= strs.length <= 200
0 <= strs[i].length <= 200
strs[i] consists of only lowercase English letters if it is non-empty.

*/



/*brute force

string prefix = string.Empty

if strs.length = 1
    return strs[0]

foreach( word in strs)
{
    first char of word = first char of every other word?

    yes => append it to prefix
           next char 

    no => next word
}

it can be only as big as the smallest word in the array

*/

Solution.LongestCommonPrefix(["flower", "flow", "flight"]);

public class Solution
{

    public static string LongestCommonPrefix(string[] strs)
    {
        if (strs.Length == 0)
            return "";

        if (strs.Length == 1)
            return strs[0];

        string prefix = string.Empty;

        for (int i = 0; i < strs[0].Length; i++)
        {
            for (int s = 0; s < strs.Length; s++)
            {
                if (i == strs[s].Length || (strs[0][i] != strs[s][i]))
                {
                    return prefix;
                }
            }
            prefix = prefix + strs[0][i].ToString();
        }
        return prefix;
    }

}