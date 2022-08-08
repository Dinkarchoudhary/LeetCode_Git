using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    class Stack
    {
        private int[] arr;
        private int top;
        private int capacity;
        
        Stack(int size)
        {
            arr = new int[size];
            top = -1;
            capacity = size; 
        }
        public bool IsEmpty()
        {
             return top == -1; ;
        }
        public bool IsFull()
        {
            return top == capacity-1;
        }
        public int Pop()
        {
            Console.WriteLine("Pooped item " + arr[top]);
            return arr[top--];

        }
        public void Push(int value)
        {
            if (IsFull())
            {
                Console.WriteLine("Stack is Full");
            }
            arr[++top] = value;
        }
        public void Print()
        {
            // Jaise isme hmlogo ne print kiya hai pura array to wo galat ho jayaega .
            // Kyuki Hame sirf top tak hi print karna hai . 
            // Yahi reason hai space utilization thik se nai ho pata hai
            //foreach(var item in arr)
            //{
            //    Console.WriteLine(item + "  ");
            //}
            for(int i =0;i<= top;i++)
            {
                Console.Write(arr[i] + "  ");
            }
            Console.WriteLine();
        }
        public static void stackImp()
        {
            Stack obj = new Stack(5);
            obj.Push(12);
            obj.Push(43);
            obj.Push(23);
            obj.Push(4);
            obj.Push(48);
            obj.Print();
            obj.Pop();
            obj.Pop();
            obj.Print();
            obj.IsEmpty();
            obj.IsFull();
        }
    }
}
