/*
 * @lc app=leetcode.cn id=198 lang=csharp
 *
 * [198] 打家劫舍
 */

// @lc code=start
public class Solution
{
    public int Rob(int[] nums)
    {
        if (nums.Length == 0)
        {
            return 0;
        }
        if (nums.Length == 1)
        {
            return nums[0];
        }
        //  动态规划        滚动数组
        int first = nums[0], second = Math.Max(nums[0], nums[1]);
        for (int i = 2; i < nums.Length; i++)
        {
            int temp = second;
            second = Math.Max(first + nums[i], second);
            first = temp;
        }
        return second;
    }
}
// @lc code=end

