using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPrep.chapter03
{
    class Queue
    {
        Node first = null;
        Node last = null;

        public void enqueue(int i)
        {
            Node n = new Node(i);
            if(last == null)
            {
                last = n;
                first = n;
                return;
            }
            last.next = n;
            last = last.next;
        }

        public Node dequeue()
        {
            if (first == null)
                return null;
            Node n = first;
            first = first.next;
            if (first == null)
                last = null;
            return n;
        }
    }
}
