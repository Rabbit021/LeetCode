using System.Collections.Generic;
using System.Linq;

namespace LeetCode.Top100
{
    public class Number20
    {
        public bool IsValid(string s)
        {
            var stack = new Stack<char>();
            var dict = new Dictionary<char, char>();
            dict['('] = ')';
            dict['['] = ']';
            dict['{'] = '}';
            foreach (var itr in s)
            {
                switch (itr)
                {
                    case '(':
                    case '[':
                    case '{':
                        stack.Push(itr);
                        break;
                    case ']':
                    case '}':
                    case ')':
                        if (!stack.Any())
                            return false;
                        var top = stack.Pop();
                        if (dict[top] != itr)
                            return false;
                        break;
                }
            }
            if (stack.Any())
                return false;
            return true;
        }
    }
}