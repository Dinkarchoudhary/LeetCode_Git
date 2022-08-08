using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.LinkedList
{
    class RemoveDuplicate
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

        static ListNode rm_duplicate(ListNode head)
        {
            ListNode dummy = new ListNode(0);
            dummy.next = head;
            ListNode curr = head;
            ListNode prev = dummy;
            if (head == null)
                return head;

            while (curr.next != null)
            {
                while (curr.next != null && curr.val == curr.next.val)
                {
                    curr = curr.next;
                }

                if (prev.next == curr)
                {
                    prev = prev.next;
                }
                else
                {
                    prev.next = curr.next;
                    curr = curr.next;
                }
            }
            return dummy.next;
        }
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
        public static void RmDuplicate()
        {
            /*push(1);
            push(2);
            push(3);
            push(3);
            push(4);
            push(4);
            push(5);*/
            push(1);
            push(1);
            push(1);
            push(2);
            push(3);
            Console.WriteLine("Given linked list");
            print();
            head = rm_duplicate(head);
            Console.WriteLine("Reversed Linked list");
            print();
        }
    }
}
