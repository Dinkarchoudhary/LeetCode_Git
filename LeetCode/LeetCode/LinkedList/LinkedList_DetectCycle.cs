using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.LinkedList
{
    class LinkedList_DetectCycle
    {
        Node head;
        public class Node
        {
            public int data;
            public Node next ;
            public Node(int d)
            {
                data = d;
                next = null;
            }
        }
        public void push(int data)
        {
            Node new_Node = new Node(data);
            new_Node.next = head;
            head = new_Node;
        }

        public int Detect_Cycle()
        {
            Node slow_Pointer = head;
            Node fast_Pointer = head;
            while (fast_Pointer != null && fast_Pointer.next != null && slow_Pointer != null)
            {
                slow_Pointer = slow_Pointer.next;
                fast_Pointer = fast_Pointer.next.next;
                if (slow_Pointer == fast_Pointer)
                {
                    return slow_Pointer.data;
                }
            }
            return -1;
        }
        /*public Node DetectCycleNode(Node head)
        {
            LinkedList_DetectCycle lList = new LinkedList_DetectCycle();
            Node meet = lList.Detect_Cycle();
            Node start = head;
            while(start != meet)
            {
                start = start.next;
                meet = meet.next;
            }
            return start;
        }*/
        public static void LinkedList_Cycle()
        {
            LinkedList_DetectCycle lList = new LinkedList_DetectCycle();
            lList.push(10);
            lList.push(15);
            lList.push(4);
            lList.push(20);
            //lList.push(56);
            //lList.push(43);
            // 4 Next means 4th element and 2 next means 2nd elements
            lList.head.next.next.next.next = lList.head.next.next;
            int data = lList.Detect_Cycle();
        }
    }
}
