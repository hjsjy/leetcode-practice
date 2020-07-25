/*
 * @lc app=leetcode.cn id=58 lang=csharp
 *
 * [58] 最后一个单词的长度
 */

// @lc code=start
public class Solution {
    public int LengthOfLastWord(string s) {
             string[] array = s.Split(' ');
            for (int i = array.Length - 1; i >= 0; i--)
            {
                if (!string.IsNullOrEmpty(array[i]))
                {
                    return array[i].Length;
                }
            }
            return 0;
    }
}
// @lc code=end

