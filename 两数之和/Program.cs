using System;
using System.Collections.Generic;

namespace 两数之和
{
    public class Solution
    {
        public static void Main(string[] args)
        {
            int[] nums = {2, 7, 11, 15};

            var twoSum = TwoSum(nums, 9);
        }

        /// <summary>
        /// 通过目标值与数组的差值，保存到dictionary比较，差值在数组中存在并且不重复
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="target"></param>
        /// <returns></returns>
        public  static int[] TwoSum(int[] nums, int target)
        {
            var dictionary = new Dictionary<int,int>();
            for (int i = 0; i < nums.Length ; i++)
            {
                var num = target - nums[i];
                if (dictionary.ContainsKey(num) && dictionary[num] != i)
                {
                    return new int[]{i,dictionary[num]};
                }
                if (!dictionary.ContainsKey(nums[i]))
                {
                    dictionary.Add(nums[i], i);
                }
            }
            return new[] {0, 0};
        }
    }
}
