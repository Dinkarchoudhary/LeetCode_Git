using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    // Refenrence Link
    // https://www.geeksforgeeks.org/linked-list-set-3-deleting-node/
    // https://www.geeksforgeeks.org/delete-a-linked-list-node-at-a-given-position/
    public class Node
    {
        public int Data { get; set; }
        public Node Next { get; set; }
        public Node(int data)
        {
            this.Data = data;
            this.Next = null;
        }
    }
    public class LinkedList1
    {
        private Node _head;
        //public LinkedList()
        //{

        //}
        public void AddToHead(int data)
        {
            // check if _head have some value
            // if not then we will set new node as head
            var newnode = new Node(data);
            if(_head == null)
            {
                _head = newnode;
                return;
            }
            newnode.Next = _head;
            _head = newnode;
        }
        public void AddtoEnd(int data)
        {
            var newNode = new Node(data);
            if(_head == null)
            {
                _head = newNode;
                return;
            }
            Node current = _head;
            while(current.Next != null)
            {
                current = current.Next;
            }
            current.Next = newNode;
        }
        public void DeleteNode(int position)
        {
            // Store head node
            Node temp = _head, prev = null;

            // If head node itself holds
            // the key to be deleted
            if (temp != null &&
                temp.Data == position)
            {
                // Changed head
                _head = temp.Next;
                return;
            }
            // Search for the key to be
            // deleted, keep track of the
            // previous node as we need
            // to change temp.next
            while (temp != null &&
                   temp.Data != position)
            {
                prev = temp;
                temp = temp.Next;
            }

            // If key was not present
            // in linked list
            if (temp == null)
                return;

            // Unlink the node from linked list
            prev.Next = temp.Next;
        }
        public void Print()
        {
            Node current = _head;
            while(current != null)
            {
                Console.WriteLine(current.Data);
                current = current.Next;
            }
        }
        public static void LList()
        {
            var list = new LinkedList1();
            Console.WriteLine("Add to Head Elements");
            list.AddToHead(10);
            list.AddToHead(20);
            list.AddToHead(30);
            Console.WriteLine("Printing Elements");
            list.Print();
            Console.WriteLine("Add to End Elements");
            list.AddtoEnd(40);
            list.AddtoEnd(50);
            Console.WriteLine("Deleting Elements");
            list.DeleteNode(20);
            Console.WriteLine("Printing Elements");
            list.Print();
        }
    }
}
