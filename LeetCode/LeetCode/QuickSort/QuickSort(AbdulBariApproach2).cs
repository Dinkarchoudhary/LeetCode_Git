using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    class QuickSort_AbdulBariApproach2
    {
        public static void QuickSort()
        {
            //int[] arr = { 10, 7, 8, 9, 1, 5 };
            int[] arr = { 10, 16, 8, 12, 15, 6,3,9,5 };
            int n = arr.Length;
            int low = 0;
            int high = n-1;
            qSort(arr, low, high);
            Console.WriteLine("---------------QUICK SORT ABDUL Bari Approach-----------------");
            foreach (var item in arr)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
        public static void qSort(int[] arr, int low , int high)
        {
            if(low < high)
            {
                int p = partitation(arr, low, high);
                qSort(arr, low, p-1);
                qSort(arr, p + 1, high);
            }
        }
        // Ye easy as jaise hi loop chalega wo direct replace kar dega.
        public static int partitation(int[] arr,int low,int high)
        {
            int pivot = arr[high];
            int j = low-1;
            for(int i = low;i<high;i++)
            {
                if(arr[i] < pivot)
                {
                    j++;
                    swap(i, j, arr);
                }
            }
            swap(j+1,high, arr);
            return j+1;
        }

        // Is method me hmlog while use kar rae hai 
        // i mera starting se start kar ra hai aur jo v pivot se chota hai use j to wapas aa raha hai usse 
        // replace kar dega 
        // Ye thora complicated hai as Multiple time same cheez hona hai.

        public static int partitation2(int[] arr, int low, int high)
        {
            int pivot = arr[low];
            int i = low;
            int j = high;
            while(i<j)
            {
                while (arr[i] < pivot)
                {
                    i++;
                }
                while (arr[j] > pivot)
                {
                    j--;
                }
                if (i < j)
                {
                    swap(i, j, arr);
                }
            }
            swap(i, j,arr);
            return j;
        }
        public static void swap(int i , int j, int[]arr)
        {
            int temp = arr[i];
            arr[i] = arr[j];
            arr[j] = temp;
        }
    }
}
