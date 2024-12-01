/* 
20_ValidParentheses_Easy

Given a string s containing just the characters '(', ')', '{', '}', '[' and ']', 
determine if the input string is valid.

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

 

Constraints:

1 <= s.length <= 104
s consists of parentheses only '()[]{}'. */

namespace LeetCodeSolutions.Problems
{
    public static class _20_ValidParentheses_Easy
    {
        public static bool Solution(string s)
        {
            bool result=true;
            var firstChar=s[0].ToString();
            string debugString="";
            //List<string> validValues= new List<string>{"(","[","{"};
            //I don't think i need a List for this, since a string is already an array of chars and it's also dynamic
            string validValues="([{";

            //Map the chars that every symbol REMOVES from the list of validChars, this way i can still keep track 
            //of the already open brackets
            Dictionary<string,string[]> negativeValues = new Dictionary<string, string[]>
            {
                { "(", [")}]",")"]},
                { "[", [")]}","]"] },
                { "{", [")]}","}"] },
                { ")", ["",""]},
                { "]", ["",""]},
                { "}", ["",""]}
            };
            //Check if first char is a closed bracket, if it is, return false
            if(validValues.Contains(firstChar)==false)
            {
                result=false;
            }

            else
            {
                for(int i=0;i<s.Length;i++)
                {
                    debugString=s[i].ToString();
                    if(validValues.Contains(s[i].ToString())==true)
                    {
                        foreach (var c in negativeValues[(s[i].ToString())][0])
                        {
                            validValues = validValues.Replace(c, ' ');
                            
                        }
                        validValues += negativeValues[(s[i].ToString())][1];
                    }
                    else return false;
                }
            }
            
            return result;
        }
    }
}
