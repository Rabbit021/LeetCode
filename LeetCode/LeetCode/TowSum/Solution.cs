﻿using System;
using System.Collections.Generic;

namespace LeetCode.TowSum
{
    public class Solution
    {
        /// <summary>
        /// 两次循环,超时
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="target"></param>
        /// <returns></returns>
        public int[] TwoSum(int[] nums, int target)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = 1; j < nums.Length; j++)
                {
                    if (i != j && nums[i] + nums[j] == target)
                    {
                        return new[] { i, j };
                    }
                }
            }
            return new int[] { };
        }

        /// <summary>
        /// 第1次优化
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="target"></param>
        /// <returns></returns>
        public int[] TwoSumV2(int[] nums, int target)
        {
            var dict = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                var data2 = target - nums[i];
                if (dict.ContainsKey(data2))
                    return new[] { dict[data2], i };
                dict[nums[i]] = i;
            }
            return new int[] { };
        }

        /// <summary>
        /// #26 去除相同元素
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public int RemoveDuplicates(int[] nums)
        {
            if (nums.Length < 2) return nums.Length;
            var index = 0;
            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[index] != nums[i])
                {
                    nums[++index] = nums[i];
                }
            }
            return index + 1;
        }

        /// <summary>
        /// #27 原地算法移除元素
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="val"></param>
        /// <returns></returns>
        public int RemoveElement(int[] nums, int val)
        {
            int index = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] != val)
                {
                    nums[index++] = nums[i];
                }

            }
            return index;
        }


        /// <summary>
        /// #35
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="target"></param>
        /// <returns></returns>
        public int SearchInsert(int[] nums, int target)
        {
            int fi = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == target)
                    return i;
                if (nums[i] <= target)
                    fi++;
            }
            return fi;
        }
    }
}
