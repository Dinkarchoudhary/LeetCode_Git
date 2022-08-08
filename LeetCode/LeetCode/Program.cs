using LeetCode.LeetCodePractice;
using LeetCode.LinkedList;
using System;


namespace LeetCode
{
    class Program
    {
        static void Main(string[] args)
        {
            

            Console.WriteLine("---------------------MERGER SORT-------------------------------------");
            // Merger Sort with Divide and Conquer
            MergerSort.MergeSort();
            Console.WriteLine("---------------------QUICK SORT-------------------------------------");
            //Quick Sort with Divide and Conquer
            QuickSort.QSort();
            Console.WriteLine("---------------------QUICK SORT(ABDUL BARI)-------------------------------------");
            //Quick Sort with Divide and Conquer - Abdul bari (Better understanding Approach)
            QuickSort_AbdulBariApproach2.QuickSort();
            //Stack Implementation 
            Console.WriteLine("-----------------------STACK IMPLEMENTATION---------------------------------");
            Stack.stackImp();
            Console.WriteLine("---------------------QUEUE-------------------------------------");
            Queue.queue();
            Console.WriteLine("---------------------PRIORITY QUEUE-------------------------------------");
            Priority_Queue.PQueue();
            Console.WriteLine("---------------------CIRCULAR QUEUE-------------------------------------");
            CircularQueue.circularQueue();
            Console.WriteLine("---------------------LINKED LIST-------------------------------------");
            LinkedList1.LList();
            Console.WriteLine("---------------------LINKED LIST SORTING-------------------------------------");
            LinkedList_Sorting.lListSort();
            Console.WriteLine("---------------------LINKED DETECT CYCLE-------------------------------------");
            LeetCode.LinkedList.LinkedList_DetectCycle.LinkedList_Cycle();
            Console.WriteLine("---------------------LINKED REVERSE-------------------------------------");
            LeetCode.LinkedList.ReverseLinkedList.ReverseLList();
            Console.WriteLine("---------------------REMOVE DUPLICATE -------------------------------------");
            LeetCode.LinkedList.RemoveDuplicate.RmDuplicate();
            Console.WriteLine("--------------------PROBLEM LEETCODE----------------------------");
            LeetCode.LeetCodePractice2.Problems();
            Console.WriteLine("----------------------MAx Min Find in Array--------------------");
            LeetCode.LeetCodePractice.Min_Max_Find_in_Array.Result();

            
        }
        
    }
}
