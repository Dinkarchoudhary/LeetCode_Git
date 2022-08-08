using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    class QuickSort
    {
        public static void QSort()
        {
            int[] arr = { 10, 7, 8, 9, 1, 5 };
            int n = arr.Length;
            // Geeks for Geeks Appraoch Taking Pivot as Last Element.
            quickSort(arr, 0, n - 1);
            Console.WriteLine("---------------QUICK SORT-----------------");
            foreach(var item in arr)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
        public static void quickSort(int[] arr, int low, int high)
        {
            if(low < high)
            {
                int pivot = partitation(arr, low, high);
                quickSort(arr, low, pivot - 1);
                quickSort(arr, pivot + 1, high);
            }
        }
        public static int partitation(int[] arr, int low, int high)
        {
            int pivot = arr[high];
            int i = low - 1;
            for(int j =low; j<= high-1;j++)
            {
                if(arr[j] < pivot)
                {
                    i++;
                    swap(arr, i, j);
                }
            }
            swap(arr, i+1,high);
            return (i+1);
        }
        public static void swap(int[] arr,int i, int j)
        {
            int temp = arr[i];
            arr[i] = arr[j];
            arr[j] = temp;
        }
    }
}
