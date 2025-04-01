using System;
using System.Collections.Generic;

namespace Solution.BracketValidation
{
    public class BracketValidator
    {
        private LinkedList<char> stack = new LinkedList<char>();

        public bool ValidasiEkspresi(string ekspresi)
        {
            foreach (var ch in ekspresi)
            {
                if (ch == '(' || ch == '{' || ch == '[')
                {
                    stack.AddLast(ch);
                }
                else if (ch == ')' || ch == '}' || ch == ']')
                {
                    if (stack.Count == 0) return false;
                    var last = stack.Last.Value;
                    if ((ch == ')' && last == '(') || (ch == '}' && last == '{') || (ch == ']' && last == '['))
                    {
                        stack.RemoveLast();
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            return stack.Count == 0;
        }
    }
}