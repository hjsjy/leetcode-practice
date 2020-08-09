/*
 * @lc app=leetcode.cn id=88 lang=csharp
 *
 * [88] 合并两个有序数组
 */

// @lc code=start
public class Solution {
    public void Merge(int[] nums1, int m, int[] nums2, int n) {
        for (int i = m; i < m + n; i++)
        {
            nums1[i] = nums2[i - m];
        }
        Array.Sort(nums1);
    }
}
// @lc code=end

