using System;
using System.Linq;

namespace 转变数组后最接近目标值的数组和
{
    /// <summary>
    /// https://leetcode-cn.com/problems/sum-of-mutated-array-closest-to-target/
    /// 注意提示
    /// </summary>

    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 4, 9, 3 };
            int target = 10;
            FindBestValue(arr, target);
        }

        public static int FindBestValue(int[] arr, int target)
        {
            int result = 0;
            int max = arr.Max();
            int sum = arr.Sum();
            int maxSum = max * arr.Length;

            for (var i = 0; i <= max; i++)
            {
                var temp = sum;

                foreach (var t in arr)
                {
                    if (t > i)
                    {
                        temp -= t - i;
                    }
                }

                if (temp - target < maxSum)
                {
                    result = i;
                    maxSum = Math.Abs(temp - target);
                }
                else
                {
                    return result;
                }
            }
            return max;
        }
    }
}
