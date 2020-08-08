/*
 * @lc app=leetcode.cn id=67 lang=csharp
 *
 * [67] 二进制求和
 */

// @lc code=start
public class Solution {
   public  string AddBinary(string a, string b)
            {
                string result = "";

                var alen = a.Length;
                var blen = b.Length;
                var carry = 0;
                for (int i = 0; i < Math.Max(alen, blen); i++)
                {
                    var ai = i < alen ? int.Parse(a[alen - i - 1].ToString()) : 0;
                    var bi = i < blen ? int.Parse(b[blen - i - 1].ToString()) : 0;

                    var temp = ai + bi + carry;
                    var ri = temp % 2;
                    result = ri + result;
                    carry = temp / 2;
                }

                if (carry != 0 )
                {
                    result = carry + result;
                }
                return result;
            }
}
// @lc code=end

