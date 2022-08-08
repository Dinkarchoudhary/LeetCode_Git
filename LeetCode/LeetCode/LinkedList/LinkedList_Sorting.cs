using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    class LinkedList_Sorting
    {
        Node head = null;
        public class Node
        {
            public int Data;
            public Node next;
            public Node(int value)
            {
                this.Data = value;
            }
        }
        // Push Element in Node 
        public void push(int new_Data)
        {
            Node new_Node = new Node(new_Data);
            new_Node.next = head;
            head = new_Node;
        }
        // Printing the Element of Linked List
        public void printList(Node current)
        {
            while(current != null)
            {
                Console.WriteLine(current.Data);
                current = current.next;
            }
        }
        Node mergeSort(Node h)
        {
            if(h == null || h.next == null)
            {
                return h;
            }
            Node middle = getMiddle(h);
            Node nextMiddle = middle.next;
            // Setting Middle node to Null
            middle.next = null;
            // Apply Merge Sort on Left List
            Node left = mergeSort(h);
            // Apply Merge Sort on Right List
            Node right = mergeSort(nextMiddle);
            // Merge Left and Right Sorted into the One
            Node sortedList = sortedMerge(left, right);
            return sortedList;
        }
        Node sortedMerge(Node left,Node right)
        {
            Node result = null;
            if(left == null)
            {
                return right;
            }
            if(right == null )
            {
                return left;
            }
            if(left.Data <= right.Data)
            {
                result = left;
                result.next = sortedMerge(result.next, right);
            }
            else
            {
                result = right;
                result.next = sortedMerge(left, right.next);
            }
            return result;
        }
        Node getMiddle(Node h)
        {
            if(h == null)
            {
                return h;
            }
            // To get the Middle Element 
            // Moving one Pointer little fast and one Pointer little slow so that fast will reach the end and then show be at the middle
            Node fastPointer = h.next;
            Node slowPointer = h;
            while(fastPointer != null)
            {
                fastPointer = fastPointer.next;
                if(fastPointer != null)
                {
                    slowPointer = slowPointer.next;
                    fastPointer = fastPointer.next;
                }
            }
            return slowPointer;
        }
        // Merging of the Element for Merger Sort
        public static void lListSort()
        {
            LinkedList_Sorting lt = new LinkedList_Sorting();
            lt.push(15);
            lt.push(10);
            lt.push(5);
            lt.push(20);
            lt.push(3);
            lt.push(2);

            // Apply merge Sort
            lt.head = lt.mergeSort(lt.head);
            Console.Write("\n Sorted Linked List is: \n");
            lt.printList(lt.head);
        }
    }
}
