/*
 * @lc app=leetcode.cn id=13 lang=csharp
 *
 * [13] 罗马数字转整数
 */

// @lc code=start
public class Solution
{
    public int RomanToInt(string s)
    {
        s = s.Replace("IV", "1");
        s = s.Replace("IX", "2");
        s = s.Replace("XL", "3");
        s = s.Replace("XC", "4");
        s = s.Replace("CD", "5");
        s = s.Replace("CM", "6");
        int sum = 0;
        for (int i = 0; i < s.Length; i++)
        {
            switch (s[i])
            {
                case '1':
                    sum += 4;
                    break;
                case '2':
                    sum += 9;
                    break;
                case '3':
                    sum += 40;
                    break;
                case '4':
                    sum += 90;
                    break;
                case '5':
                    sum += 400;
                    break;
                case '6':
                    sum += 900;
                    break;

                case 'M':
                    sum += 1000;
                    break;
                case 'D':
                    sum += 500;
                    break;
                case 'C':
                    sum += 100;
                    break;
                case 'L':
                    sum += 50;
                    break;
                case 'X':
                    sum += 10;
                    break;
                case 'V':
                    sum += 5;
                    break;

                case 'I':
                    sum += 1;
                    break;
            }
        }
        return sum;

    }
}
// @lc code=end

