using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.LeetCodePractice
{
    class Min_Max_Find_in_Array
    {
        public static void Result()
        {
            int[] arr = { 1000, 11, 445, 1, 330, 3000 };
            int arr_size = 6;
            getMinMax(arr, arr_size);
        }
        public static void getMinMax(int[] arr,int arr_size)
        {
            int max = arr[0];
            int min = arr[0];
            foreach(var item in arr)
            {
                if(item > max)
                {
                    max = item;
                }
                if(item < min)
                {
                    min = item;
                }
            }
            Console.WriteLine(max + " " + min);
        }
    }
}
