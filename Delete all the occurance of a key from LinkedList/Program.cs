using System;

namespace Delete_all_the_occurance_of_a_key_from_LinkedList
{
    class Program
    {

        public class LinkedList
        {
            public Node head { get; set; }
        }
        public class Node
        {
            public int value;
            public Node next;
            public Node(int val = 0)
            {
                value = val;
                next = null;
            }
        }

        static void Main(string[] args)
        {
            LinkedList linkedList = new LinkedList();
            Node dummy = new Node();
            Add(1, linkedList);
            dummy.next = linkedList.head;
            Add(2, linkedList);
            Add(3, linkedList);
            Add(1, linkedList);
            Add(1, linkedList);
            Add(1, linkedList);
            Add(4, linkedList);
            Node node = DeleteAllNodesWithValue(1, dummy.next);
            Print(node);
        }

        static void Add(int value, LinkedList linkedList)
        {
            Node node = new Node(value);
            if (linkedList.head == null) linkedList.head = node;
            else
            {
                linkedList.head.next = node;
                linkedList.head = node;
            }
        }

        static void DeleteAllNodesWithValueUsingDummy(int key, Node head)
        {
            Node dummy = new Node();
            dummy.next = head;
            Node current = dummy;
            while(current.next != null)
            {
                if (current.next.value == key) current.next = current.next.next;
                else current = current.next;
            }
        }

        static Node DeleteAllNodesWithValue(int key, Node head)
        {
            Node temp = head;
            while (temp != null && temp.next != null)
            {
                if (temp.next.value == key) temp.next = temp.next.next;
                else temp = temp.next;
            }

            if (head.value == key) head = head.next;
            return head;
        }

        static void Print(Node head)
        {
            Node current = head;
            while (current != null)
            {
                Console.WriteLine(current.value);
                current = current.next;
            }
        }
    }
}
