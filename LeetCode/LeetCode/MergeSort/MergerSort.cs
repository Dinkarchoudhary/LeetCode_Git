using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    class MergerSort
    {
        public static void MergeSort()
        {
            int[] arr = { 12, 11, 13, 5, 6, 7 };
            int l = 0;
            int r = arr.Length - 1;
            sort(arr, l, r);
            Console.WriteLine("---------------MERGE SORT--------------");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
        }
        public static void sort(int[] arr, int l, int r)
        {
            if (l < r)
            {
                int m = l + (r - l) / 2;
                sort(arr, l, m);
                sort(arr, m + 1, r);
                // Merger 
                merge(arr, l, m, r);
            }
        }
        public static void merge(int[] arr, int l, int m, int r)
        {
            int n1 = m - l + 1;
            int n2 = r - m;
            //Temp Array Created
            int[] temp1 = new int[n1];
            int[] temp2 = new int[n2];
            int i, j;
            //Copy into the First Array 
            for (i = 0; i < n1; i++)
            {
                temp1[i] = arr[l + i];
            }
            // Copy into the Second Array 
            for (j = 0; j < n2; j++)
            {
                temp2[j] = arr[m + 1 + j];
            }
            i = 0;
            j = 0;
            int k = l;
            while (i < n1 && j < n2)
            {
                if (temp1[i] <= temp2[j])
                {
                    arr[k] = temp1[i];
                    i++;
                }
                else
                {
                    arr[k] = temp2[j];
                    j++;
                }
                k++;
            }

            while (i < n1)
            {
                arr[k] = temp1[i];
                i++;
                k++;
            }
            while (j < n2)
            {
                arr[k] = temp2[j];
                j++;
                k++;
            }
        }
    }
}
