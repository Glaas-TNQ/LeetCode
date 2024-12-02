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
           
            var parentesiChiusa = new List<char>(); // Usare una lista per facilità di gestione
            string validValues = "([{";
            Dictionary<char, char> matchingBrackets = new Dictionary<char, char>
            {
                { ')', '(' },
                { ']', '[' },
                { '}', '{' }
            };

            for (int i = 0; i < s.Length; i++)
            {
                char currentChar = s[i];

                // Se è una parentesi aperta, aggiungila alla lista delle parentesi aperte
                if (validValues.Contains(currentChar))
                {
                    parentesiChiusa.Add(currentChar);
                }
                // Se è una parentesi chiusa
                else if (matchingBrackets.ContainsKey(currentChar))
                {
                    // Controlla se corrisponde all'ultima parentesi aperta
                    if (parentesiChiusa.Count == 0 || parentesiChiusa[^1] != matchingBrackets[currentChar])
                    {
                        return false;
                    }
                    // Rimuovi l'ultima parentesi aperta
                    parentesiChiusa.RemoveAt(parentesiChiusa.Count - 1);
                }
                else
                {
                    // Carattere non valido
                    return false;
                }
            }

            // Se alla fine ci sono ancora parentesi aperte non chiuse, la stringa non è valida
            return parentesiChiusa.Count == 0;
    }
        
    }
}
