using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 2, 7, 11, 15 };
            int target = 9;
            int[] result = TwoSum(nums, target);
            ClusyFactorial();
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
        }

        public static int ClusyFactorial()
        {
            int n = 10;
            var stack = new Stack<int>();
            char[] op = { '*', '/', '+', '-' };
            int index = 0;
            stack.Push(n--);
            while (n > 0)
            {
                if (op[index] == '*') stack.Push(stack.Pop() * n--);
                if (op[index] == '/') stack.Push(stack.Pop() / n--);
                if (op[index] == '+') stack.Push(stack.Pop() + n--);
                if (op[index] == '-') stack.Push(stack.Pop() - n--);
                if (index == 3) index = 0;
                else index++;
            }
            int item = stack.Peek();
            return item;

            /*
            int N = 4;
            var stack = new Stack<int>();
            var op = new char[] { '*', '/', '+', '-' };
            stack.Push(N--);
            int index = 0;
            while (N > 0)
            {
                if (op[index] == '*') stack.Push(stack.Pop() * N--);
                else if (op[index] == '/') stack.Push(stack.Pop() / N--);
                else if (op[index] == '+') stack.Push(N--);
                else if (op[index] == '-') stack.Push(-1 * (N--));
                index = index == op.Length - 1 ? 0 : index + 1;
            }

            return stack.Sum();
            */

        }
        public static int[] TwoSum(int[] nums, int target)
        {
            int[] result = new int[nums.Length];
            Dictionary<int, int> dict = new Dictionary<int, int>();
            int z = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (!dict.ContainsKey(nums[i]))
                {
                    dict.Add(nums[i], target - nums[i]);
                }
                else
                {
                    if (dict.ContainsValue(nums[i]))
                    {
                        int myKey = dict.FirstOrDefault(x => x.Value == nums[i]).Key;
                        result[z] = myKey;
                        z++;
                        result[z] = nums[i];
                    }
                }
            }
            return result;
        }
    }
}
