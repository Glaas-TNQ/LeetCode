using System;
using LeetCodeSolutions.Problems;

namespace LeetCodeSolutions
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "([])";
            bool solution = false;

            // Chiama il metodo Solution (modifica il nome della classe se necessario)
            solution = _20_ValidParentheses_Easy.Solution(s);

            Console.WriteLine($"La soluzione è: {solution}");
        }
    }
}
