using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPrep.chapter02
{
    public class Node
    {
        public Node next = null;
        public int data;

        public Node(int d)
        {
            data = d;
        }

        void appendToTail(int d) 
        {
            Node end = new Node(d);
            Node n = this;
            while (n.next != null)
                n = n.next;
            n.next = end;
        }

        public static Node createLinkedList(int[] nums)
        {
            Node n = new Node(nums[0]);
            Node head = n;
            for (int i = 1; i < nums.Length; i++)
            {
                Node next = new Node(nums[i]);
                n.next = next;
                n = next;
            }
            return head;
        }

        public static void printNodes(Node head)
        {
            while (head != null)
            {
                Console.Write(head.data);
                Console.Write(" -> ");
                head = head.next;
            }
            Console.Write("null\n");
        }
    }
}
