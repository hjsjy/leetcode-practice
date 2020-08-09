/*
 * @lc app=leetcode.cn id=202 lang=csharp
 *
 * [202] 快乐数
 */

// @lc code=start
public class Solution {
      public  bool IsHappy(int n)
        {

            var list = new List<int>();

            while (true)
            {
                var s = n.ToString();
                var result = s.Select((t, i) => int.Parse(t.ToString())).Sum(i => i*i);
                if (result == 1)
                {
                    return true;
                }

                if (list.Contains(result))
                {
                    return false;
                }
                list.Add(result);
                n = result;
            }
        }
}
// @lc code=end

