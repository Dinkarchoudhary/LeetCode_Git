using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    class CircularQueue
    {
        private int front;
        private int rear;
        private int capacity;
        private int[] arr;
        // As this is Circular Queue
        // rear shoule keep rotating suppose from front we have deleted 2 
        // Index reaches to 2 as a front 
        // then in that case rear should be (rear +1 ) % SIZE = (5 + 1) % SIZE = then return 1 which was previous front Index
        // For Circular Queue
        // Front Queue ka index hamesha 0 rahega and rear will be moving
        // For Insertion
        // We will keep moving the Rear item one by one
        // For Delete
        // We will keep moving the front item one by one.
        CircularQueue(int size)
        {
            front = rear = -1;
            capacity = size;
            arr = new int[size];
        }

        public bool isQueueFull()
        {
            if(front == 0 && rear == capacity -1)
            {
                return true;
            }
            if(front == rear +1)
            {
                return true;
            }
            return false;
        }
        public bool isEmpty()
        {
            if(front == -1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public void EnQueue(int value)
        {
            if(isQueueFull())
            {
                Console.WriteLine("Queue is Full");
            }
            else
            {
                if(front == -1)
                {
                    front = 0;
                }
                rear = (rear + 1) % capacity;
                arr[rear] = value;
                Console.WriteLine("Inserted " + value);
            }
        }
        public int DeQueue()
        {
            int item;
            if(isEmpty())
            {
                Console.WriteLine("Queue is Empty");
                return -1;
            }
            else
            {
                item = arr[front];
                if(front == rear)
                {
                    front = -1;
                    rear = -1;
                }
                else
                {
                    front = (front + 1) % capacity;
                }
                return item;
            }
        }

        public void Display()
        {
            int i;
            if (isEmpty())
            {
                Console.WriteLine("Empty Queue");
            }
            else
            {
                Console.WriteLine("Front -> " + front);
                Console.WriteLine("Items -> ");
                for (i = front; i != rear; i = (i + 1) % capacity)
                    Console.WriteLine(arr[i] + " ");
                Console.WriteLine(arr[i]);
                Console.WriteLine("Rear -> " + arr[rear]);
            }
        }
        public static void circularQueue()
        {
            CircularQueue q = new CircularQueue(5);
            q.EnQueue(1);
            q.EnQueue(2);
            q.EnQueue(3);
            q.EnQueue(4);
            q.EnQueue(5);
            // For Displaying
            q.DeQueue();
            q.Display();
            int item = q.DeQueue();
            if (item != -1)
            {
                Console.WriteLine("Deleted Element is " + item);
            }
            q.Display();

            q.EnQueue(7);

            q.Display();

            // Fails to enqueue because front == rear + 1
            q.EnQueue(8);
        }
    }
}
