using System.Collections.Generic;

namespace 每日温度
{
    /// <summary>
    ///请根据每日 气温 列表，重新生成一个列表。对应位置的输出为：要想观测到更高的气温，至少需要等待的天数。如果气温在这之后都不会升高，请在该位置用 0 来代替。

    ///例如，给定一个列表 temperatures = [73, 74, 75, 71, 69, 72, 76, 73]，你的输出应该是[1, 1, 4, 2, 1, 1, 0, 0]。

    ///提示：气温 列表长度的范围是[1, 30000]。每个气温的值的均为华氏度，都是在[30, 100] 范围内的整数。

    ///通过次数78,825提交次数123,995
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            int[] num = { 5, 4, 2, 3, 69, 72, 76, 73 };
            DailyTemperatures(num);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="T"></param>
        /// <returns></returns>
        public static int[] DailyTemperatures(int[] T)
        {
            int len = T.Length;
            var stack = new Stack<int>();
            int[] result = new int[len];
            for (int i = len - 1; i >= 0; i--)
            {
                while (stack.Count != 0 && T[stack.Peek()] <= T[i])
                    stack.Pop();
                if (stack.Count != 0)
                    result[i] = stack.Peek() - i;
                stack.Push(i);
            }
            return result;




            // int len = T.Length;
            // Stack<int> stack = new Stack<int>();
            // int[] result = new int[len];
            // for (int i = len - 1; i >= 0; i--)
            // {
            //     while (stack.Count != 0 && T[stack.Peek()] <= T[i])
            //         stack.Pop();
            //     if (stack.Count != 0)
            //         result[i] = stack.Peek() - i;
            //     stack.Push(i); }
            // return result;
            // Stack<int> stack = new Stack<int>();
            // int[] ret = new int[T.Length];
            // for (int i = T.Length - 1; i> 0;   i--)
            // {
            //     while (stack.Count > 0 && T[i] < T[stack.Peek()])
            //     {
            //         var pop = stack.Pop();
            //         ret[i] =pop -i;
            //     }
            //     stack.Push(i);
            // }
            //
            // return ret;

            // Stack<int> stack = new Stack<int>();
            // int[] ret = new int[T.Length];
            // ret[T.Length - 1] = 0;
            // for (int i = 0; i < T.Length; i++)
            // {
            //     while (stack.Count > 0 && T[i] > T[stack.Peek()])
            //     {
            //         int tmp = stack.Pop();
            //         ret[tmp] = i - tmp;
            //     }
            //     stack.Push(i);
            // }
            // return ret;
        }
    }

}
