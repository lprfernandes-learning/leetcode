/*20. Valid Parentheses
Easy

Given a string s containing just the characters '(', ')', '{', '}', '[' and ']', determine if the input string is valid.

An input string is valid if:

Open brackets must be closed by the same type of brackets.
Open brackets must be closed in the correct order.
Every close bracket has a corresponding open bracket of the same type.
 

Example 1:
Input: s = "()"
Output: true

Example 2:
Input: s = "()[]{}"
Output: true

Example 3:
Input: s = "(]"
Output: false

Example 4:
Input: s = "([])"
Output: true

Example 5:
Input: s = "([)]"
Output: false


Constraints:

1 <= s.length <= 104
s consists of parentheses only '()[]{}'.

*/


Console.WriteLine(Solution.IsValid("()"));

public class Solution
{
    public static bool IsValid(string s)
    {
        if (s.Length < 2)
        {
            return false;
        }

        Dictionary<char, char> braces = new()
        {
            {'(',')'},
            {'[',']'},
            {'{','}'}
        };

        Stack<char> opens = new();

        foreach (char item in s)
        {
            //if it's an opening brace
            if (braces.ContainsKey(item))
            {
                //add it to the stack
                opens.Push(item);
            }
            //if it's an closing brace but there are no openings braces to match or 
            // the closing brace isn't the pair of the last seen opening brace 
            else if (opens.Count == 0 || item != braces[opens.Pop()])
            {
                return false;
            }
        }
        return opens.Count == 0;
    }
}