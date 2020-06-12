using System;
using System.Collections.Generic;
using System.Linq;

namespace 拥有最多糖果的孩子
{


    // 给你一个数组 candies和一个整数 extraCandies，其中 candies[i]代表第 i 个孩子拥有的糖果数目。
    //
    // 对每一个孩子，检查是否存在一种方案，将额外的 extraCandies个糖果分配给孩子们之后，此孩子有 最多的糖果。注意，允许有多个孩子同时拥有 最多的糖果数目。

    class Program
    {
        static void Main(string[] args)
        {
            int[] candies = {2, 3, 5, 1, 3};
            int extraCandies = 3;
            KidsWithCandies(candies, extraCandies);
        }
        /// <summary>
        ///解题思路     遍历数组，判断每个元素是否是数组里的最大值
        /// </summary>
        /// <param name="candies"></param>
        /// <param name="extraCandies"></param>
        /// <returns></returns>
        public static  IList<bool> KidsWithCandies(int[] candies, int extraCandies)
        {
            var resultList = new List<bool>();
            foreach (var t in candies)
            {
                var candiesAdded = t + extraCandies;
                var candiesAddedIsMax = candies.Max() <= candiesAdded;
                resultList.Add(candiesAddedIsMax);
            }
            return resultList;
        }
    }
}
