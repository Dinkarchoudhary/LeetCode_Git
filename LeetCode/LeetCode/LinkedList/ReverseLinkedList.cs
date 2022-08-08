using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.LinkedList
{
    class ReverseLinkedList
    {
        public static ListNode head;
        public class ListNode
        {
            public int val;
            public ListNode next;
            public ListNode(int val, ListNode next = null)
            {
                this.val = val;
                this.next = next;
            }
        }

        static ListNode reverse(ListNode head)
        {
            if (head == null ||
                head.next == null)
                return head;

            // Reverse the rest list and put 
            // the first element at the end
            ListNode rest = reverse(head.next);
            head.next.next = head;

            // Tricky step --
            // see the diagram
            head.next = null;

            // Fix the head pointer
            return rest;
        }

        // Function to print
        // linked list
        static void print()
        {
            ListNode temp = head;
            while (temp != null)
            {
                Console.Write(temp.val + " ");
                temp = temp.next;
            }
            Console.WriteLine();
        }

        static void push(int data)
        {
            ListNode temp = new ListNode(data);
            temp.next = head;
            head = temp;
        }

        // Driver code
        public static void ReverseLList()
        {
            // Start with the
            // empty list
            push(1);
            push(2);
            push(3);
            push(4);

            Console.WriteLine("Given linked list");
            print();
            head = reverse(head);
            Console.WriteLine("Reversed Linked list");
            print();
        }
    }
}
