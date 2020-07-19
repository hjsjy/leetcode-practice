/*
 * @lc app=leetcode.cn id=9 lang=csharp
 *
 * [9] 回文数
 */

// @lc code=start
public class Solution {
    public bool IsPalindrome(int x) {
      if(x < 0 || (x%10 ==0 && x != 0 )) return false;
     int revertNumber =  0;
     while (x >  revertNumber ){
         revertNumber = revertNumber *10 + x %10;
         x /= 10;
     }
        return  x == revertNumber || x == revertNumber/10;
    }
}
// @lc code=end
// 小李子已阅(✪▽✪)
