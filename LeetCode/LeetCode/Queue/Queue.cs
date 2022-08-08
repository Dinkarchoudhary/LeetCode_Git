using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    class Queue
    {
        private int front;
        private int rear;
        private int[] arr;
        private int capacity;
        Queue(int size)
        {
            arr = new int[size];
            front = rear= 0;
            capacity = size;
        }
        public void Enqueue(int item)
        {
            if (capacity == rear)
            {
                Console.WriteLine("Queue is Full");
            }
            else
            {
                arr[rear] = item;
                rear++;
            }
        }
        public void Dequeue()
        {
            if(front == rear)
            {
                Console.WriteLine("Queue is Empty");
            }
            else
            {
                Console.WriteLine("Pooped Item: " + arr[front]);
                for (int i =0;i<rear-1;i++)
                {
                    arr[i] = arr[i + 1];
                }
                if(rear < capacity)
                {
                    arr[rear] = 0;
                }
                rear--;
            }
        }
        public void Display()
        {
            if (front == rear)
            {
                Console.WriteLine("Array is Empty");
            }
            else
            {
                for (int i = front; i < rear; i++)
                {
                    Console.Write(arr[i] + " ");
                }
            }
            Console.WriteLine();
        }
        public static void queue()
        {
            Queue obj = new Queue(5);
            obj.Enqueue(23);
            obj.Enqueue(34);
            obj.Enqueue(76);
            obj.Enqueue(93);
            obj.Enqueue(19);
            obj.Display();
            obj.Dequeue();
            obj.Display();
            //Enqueue - Insert
            //Dequeue - Remove  
            //Front - 
            //Display
            // Front = rear = -1
        }
    }
}
