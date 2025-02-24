using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommitAndConquer
{
    public class Valid_Parentheses
    {
        public static bool IsValid(string s)
        {
            var stack = new Stack<char>();

            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == '[' || s[i] == '{' || s[i] == '(')
                {
                    stack.Push(s[i]);
                }
                else if (s[i] == ']' ||  s[i] == '}' ||  s[i] == ')')
                {
                    if (stack.Count <= 0) return false;

                    var item = stack.Pop();

                    switch (item)
                    {
                        case '(' when s[i] != ')': return false;
                        case '[' when s[i] != ']': return false;
                        case '{' when s[i] != '}': return false;
                    }
                }
            }

            if (stack.Count == 0)
            {
                return true;
            }

            return false;
        }
    }
}
