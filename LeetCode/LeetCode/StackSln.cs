using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode
{
    /// <summary>
    /// 栈类型的算法
    /// </summary>
    public class StackSln
    {
        /// <summary>
        /// #20 有效括号问题
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public bool IsValid(string s)
        {
            var stack = new Stack<char>();
            var dict = new Dictionary<char, char>()
            {
                { '(',')'},
                { '[',']'},
                { '{','}'}
            };
            for (var i = 0; i < s.Length; i++)
            {
                if (dict.ContainsKey(s[i]))
                {
                    stack.Push(s[i]);
                }
                else
                {
                    if (!stack.Any())
                        return false;
                    var top = stack.Pop();
                    if (dict[top] != s[i])
                        return false;
                }
            }
            return !stack.Any();
        }
    }
}