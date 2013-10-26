using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPrep.chapter03
{

    public class Stack
    {
        public Node top = null;
        public virtual void Push(int i)
        {
            Node n = new Node(i);
            n.next = top;
            top = n;
        }

        public virtual void Push(Node n)
        {
            n.next = top;
            top = n;
        }

        public virtual Node Pop()
        {
            if (top == null)
                return null;
            Node n = top;
            top = top.next;
            return n;
        }

        public override string ToString()
        {
            StringBuilder s = new StringBuilder();
            Node temp = top;
            while (temp != null)
            {
                s.Append(temp.data + " ");
                temp = temp.next;
            }
            return s.ToString();
        }

        public bool IsEmpty()
        {
            return top == null;
        }

        public Node Peek()
        {
            return top;
        }

        public int GetSize()
        {
            int count = 0;
            Node temp = top;
            while (temp != null)
            {
                count++;
                temp = temp.next;
            }
            return count;
        }
    }

    public class Node
    {
        public int data;
        public Node next;
        public Node(int i)
        {
            data = i;
        }
    }
}
