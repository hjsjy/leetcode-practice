/*
 * @lc app=leetcode.cn id=118 lang=csharp
 *
 * [118] 杨辉三角
 */

// @lc code=start
public class Solution
{
     public  IList<IList<int>> Generate(int numRows)
        {
            var list = new List<IList<int>>();
            for (var i = 1; i <= numRows; i++)
            {
                if (0 < i && i <= 2)
                {
                    var list1 = new List<int>();
                    var num1 = i;
                    while (num1 > 0)
                    {
                        list1.Add(1);
                        num1--;
                    }
                    list.Add(list1);
                }
                else
                {
                    var list2 = new List<int>();
                    for (var j = 0; j < i - 1; j++)
                    {
                        if (j == 0 )
                        {
                            list2.Add(1);
                        }
                        else
                        {
                            var num = list[i - 2][j-1] + list[i - 2][j];
                            list2.Add(num);
                        }

                        if (j == i - 2)
                        {
                            list2.Add(1);
                        }
                    }
                    list.Add(list2);
                }
            }
            return list;
            //test
        }
}
// @lc code=end

