using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPrep.chapter03
{

    class Stack
    {
        Node top = null;
        void Push(int i)
        {
            Node n = new Node(i);
            n.next = top;
            top = n;
        }

        void Push(Node n)
        {
            n.next = top;
            top = n;
        }

        Node Pop()
        {
            if (top == null)
                return null;
            Node n = top;
            top = top.next;
            return n;
        }
    }

    class Node
    {
        public int data;
        public Node next;
        public Node(int i)
        {
            data = i;
        }
    }
}
