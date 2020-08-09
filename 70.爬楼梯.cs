/*
 * @lc app=leetcode.cn id=70 lang=csharp
 *
 * [70] 爬楼梯 （动态规划）
 */


// @lc code=start
public class Solution {
    public int ClimbStairs(int n) {
        int  p, q = 0;
        int result  = 1;
//滚动数组
        for (int i = 1; i <= n; i++)
        {
            p = q ;
            q =result ;
            result = p +q;
        }
        return result;
    }
}
// @lc code=end

