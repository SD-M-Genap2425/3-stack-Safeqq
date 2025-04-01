using System;
using System.Collections.Generic;

namespace Solution.BracketValidation
{
    public class BracketValidator
    {
        public bool ValidasiEkspresi(string ekspresi)
        {
            var stack = new LinkedList<char>();

            foreach (var ch in ekspresi)
            {
                if (ch == '(' || ch == '{' || ch == '[')
                {
                    stack.AddLast(ch);
                }
                else if (ch == ')' || ch == '}' || ch == ']')
                {
                    if (stack.Count == 0)
                        return false;

                    var top = stack.Last.Value;
                    stack.RemoveLast();

                    if (!IsValidPair(top, ch))
                        return false;
                }
            }

            return stack.Count == 0;
        }
        private bool IsValidPair(char opening, char closing)
        {
            return (opening == '(' && closing == ')') ||
                   (opening == '{' && closing == '}') ||
                   (opening == '[' && closing == ']');
        }
    }
}