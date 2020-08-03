/*
 * @lc app=leetcode.cn id=53 lang=csharp
 *
 * [53] 最大子序和
 */

// @lc code=start
public class Solution {
    public int MaxSubArray(int[] nums) {
        int pre = 0;
        int max = nums[0];
        foreach (var item in nums)
        {
            pre = Math.Max(pre + item, item);
            max = Math.Max(pre,max);
        }
        return max;
    }
}
// @lc code=end

