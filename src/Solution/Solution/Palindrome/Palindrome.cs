using System;
using System.Collections.Generic;

namespace Solution.Palindrome
{
    public static class PalindromeChecker
    {
        public static bool CekPalindrom(string input)
        {
            var normalizedInput = new string(input
                .Where(c => Char.IsLetterOrDigit(c))
                .Select(c => Char.ToLower(c))
                .ToArray());

            var stack = new Stack<char>();
            
            foreach (var c in normalizedInput)
            {
                stack.Push(c);
            }

            foreach (var c in normalizedInput)
            {
                if (c != stack.Pop())
                    return false;
            }
            return true;
        }
    }
}
