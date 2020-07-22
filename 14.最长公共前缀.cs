/*
 * @lc app=leetcode.cn id=14 lang=csharp
 *
 * [14] 最长公共前缀
 */

// @lc code=start
public class Solution
{
    public string LongestCommonPrefix(string[] strs)
    {
        var result = "";
        if(strs == null || strs.Length == 0)
        return result;
        for (int i = 0; i < strs[0].Length; i++)
        {
            var temp = strs[0][i];
            for (int j = 1 ; j < strs.Length; j++)
            {
                if (i > strs[j].Length -1)
                {
                    return result;
                }

                if (temp != strs[j][i])
                {
                    return result;
                }
            }
            result += temp;
        }
        return result;

    }
}
// @lc code=end

