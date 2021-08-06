using System;
using System.Collections.Generic;
using System.Linq;
namespace Codewars
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        /*
         * Write a function that takes an array of numbers (integers for the tests) and a target number.
         * It should find two different items in the array that, when added together, give the target value. 
         * The indices of these items should then be returned in a tuple like so: (index1, index2).

For the purposes of this kata, some tests may have multiple answers; any valid solutions will be accepted.

The input will always be valid (numbers will be an array of length 2 or greater, and all of the items will be numbers; target will always be the sum of two different items from that array).

Based on: http://oj.leetcode.com/problems/two-sum/

        twoSum [1, 2, 3] 4 === (0, 2)
        */

        public static int[] TwoSum(int[] nums, int target)
        {
            var d = new System.Collections.Generic.Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                if (d.ContainsKey(nums[i])) return new int[] { d[nums[i]], i };
                if (!d.ContainsKey(target - nums[i])) d.Add(target - nums[i], i);
            }
            return null;
        }

        public static IEnumerable<int> GetIntegersFromList(List<object> listOfItems)
        {
            //var l = new List<int>();
            //foreach (object item in listOfItems)
            //{
            //    if (item is int) l.Add((int)item);
            //}
            //return l;
            // 下面是新抄到的方法
            return listOfItems.OfType<int>();
        }
    }
}
