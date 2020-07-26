/*
 * @lc app=leetcode.cn id=28 lang=csharp
 *
 * [28] 实现 strStr()
 */

// @lc code=start
public class Solution
{  public  int StrStr(string haystack, string needle)
        {
            var hl = haystack.Length;
            var nl = needle.Length;
            if (nl == 0) return 0;
            int hi = 0;
            while (hi < hl - nl + 1)
            {
                while (hi < hl - nl + 1 && haystack[hi] != needle[0]) ++hi;
                int currentl = 0;
                int ni = 0;

                while (ni < nl && hi < hl && haystack[hi] == needle[ni])
                {
                    ++hi;
                    ++ni;
                    ++currentl;
                }
                if (currentl == nl) return hi - nl;
                // 回溯
                hi = hi - currentl + 1;
            }
            return -1;
        }
}
// @lc code=end

