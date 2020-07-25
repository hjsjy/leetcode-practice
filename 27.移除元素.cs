/*
 * @lc app=leetcode.cn id=27 lang=csharp
 *
 * [27] 移除元素
 */

// @lc code=start
public class Solution {
    public int RemoveElement(int[] nums, int val) {
        int i= 0;
        for(var j = 0; j < nums.Length ; j ++){
            if(nums[j] != val){
                 nums[i] = nums[j];
                 i++;
            }
        }
        return i;
    }
}
// @lc code=end

