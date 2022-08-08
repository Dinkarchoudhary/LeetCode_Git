using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    class Priority_Queue
    {
        public class Node
        {
            public int priority;
            public Node next;
            public int data;
        }
        public static Node node = new Node();
        public static Node newNode(int data, int priority)
        {
            Node temp = new Node();
            temp.data = data;
            temp.next = null;
            temp.priority = priority;
            return temp;
        }
        public static int Peek(Node head)
        {
            return head.data;
        }
        public static Node Pop(Node head)
        {
            Node temp = head;
            head = head.next;
            return head;
        }
        public static Node Push(Node head,int data,int priority)
        {
            Node start = head;
            Node temp = newNode(data, priority);
            if(head.priority > data)
            {
                temp.next = head;
                head = temp;
            }
            else
            {
                while(start.next != null && start.next.priority < priority)
                {
                    start = start.next;
                }
                temp.next = start.next;
                start.next = temp;
            }
            return head;
        }
        public static int IsEmpty(Node head)
        {
            return (head == null) ? 1 : 0;
        }

        public static void PQueue()
        {
            Node p = newNode(4, 1);
            p = Push(p, 5, 2);
            p = Push(p, 6, 3);
            p = Push(p, 7, 0);
            while (IsEmpty(p) == 0)
            {
                Console.WriteLine("{0:D} ", Peek(p));
                p = Pop(p);
            }
        }
    }
}
