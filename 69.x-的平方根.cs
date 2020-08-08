/*
 * @lc app=leetcode.cn id=69 lang=csharp
 *
 * [69] x 的平方根
 */

// @lc code=start
public class Solution {
           public  int MySqrt(int x)
        {
            if (x == 0) return 0;
            int left = 1, right = x, mid = (left+right)/2;
            while(left<right&&mid!=left)
            {
                if(mid== x/mid)
                {
                    return mid;
                }else if(mid < x / mid)
                {
                    left = mid;
                    mid = (left + right) / 2;
                }
                else
                {
                    right = mid;
                    mid = (left + right) / 2;
                }
            }
                return left;
        }
}
// @lc code=end

