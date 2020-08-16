/*
 * @lc app=leetcode.cn id=374 lang=csharp
 *
 * [374] 猜数字大小
 */

// @lc code=start
/** 
 * Forward declaration of guess API.
 * @param  num   your guess
 * @return 	     -1 if num is lower than the guess number
 *			      1 if num is higher than the guess number
 *               otherwise return 0
 * int guess(int num);
 */

public class Solution : GuessGame {
    public int GuessNumber(int n) {
        int result = 0;
         switch(guess(n)){
         case -1:
            n = n /2 ;
            case 1 :

            case 0:
            return result;
     }
    
    }
}
// @lc code=end

