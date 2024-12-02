/* Given an integer x, return true if x is a 
palindrome
, and false otherwise.

 

Example 1:

Input: x = 121
Output: true
Explanation: 121 reads as 121 from left to right and from right to left.
Example 2:

Input: x = -121
Output: false
Explanation: From left to right, it reads -121. From right to left, it becomes 121-. Therefore it is not a palindrome.
Example 3:

Input: x = 10
Output: false
Explanation: Reads 01 from right to left. Therefore it is not a palindrome.
 

Constraints:

-231 <= x <= 231 - 1
 

Follow up: Could you solve it without converting the integer to a string? */

namespace LeetCodeSolutions.Problems
{
    public static class _09_PalindromeNumber_Easy
    {
        public static bool Solution(int x)
        {
             //Cast the INT to a string
        string convertedInt=x.ToString();

        bool isPalindrome=false;

        //Convert the string to an array of characters and then invert it
        //Be careful not to try and assign the Reverse to char[] as Reverse is a void method
        char[] convertedString=convertedInt.ToCharArray();
        char[] reverseArray = (char[])convertedString.Clone();
        Array.Reverse(reverseArray);

        //If the two are equals, then it's palindrome, else not

        isPalindrome = Enumerable.SequenceEqual(convertedString, reverseArray);

        return isPalindrome;
        }
    }

}