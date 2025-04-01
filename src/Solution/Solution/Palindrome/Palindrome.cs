using System;
using System.Collections.Generic;
using System.Linq;

namespace Solution.Palindrome
{
    public static class PalindromeChecker
    {
        public static bool CekPalindrom(string input)
        {
            var stack = new Stack<char>();
            var cleanedInput = string.Concat(input.Where(c => char.IsLetterOrDigit(c)).Select(c => char.ToLower(c)));

            foreach (var ch in cleanedInput)
            {
                stack.Push(ch);
            }

            foreach (var ch in cleanedInput)
            {
                if (stack.Pop() != ch)
                {
                    return false;
                }
            }

            return true;
        }
    }
}
