/*
 * @lc app=leetcode.cn id=20 lang=csharp
 *
 * [20] 有效的括号
 */

// @lc code=start
public class Solution {
       public bool IsValid(string s)
        {
            var dictionary = new Dictionary<string, string>
            {
                {"{", "}"},
                {"(", ")"},
                {"[", "]"}
            }; 
            var stack = new Stack<char>();
            for (int i = 0; i < s.Length; i++)
            {
                
                if (s[i] == '{' ||s[i] == '[' || s[i] == '(')
                {
                    stack.Push(s[i]);
                }1
                else
                {
                    if (stack.Count == 0)
                    {
                        return false;
                    }
                    if (dictionary.TryGetValue(stack.Pop().ToString(), out  var value) 
                        && value == s[i].ToString())
                    {
                        
                    }
                    else
                    {
                        return false;
                    }
                }
            }

            if (stack.Count == 0)
                return true;
            return false;
        }
}
// @lc code=end

