using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPrep.chapter02
{
    class question0204
    {
        static void NotMain(String[] args)
        {
            Node l = Node.createLinkedList(new int[] { 3, 1, 2, 4, 5, 9, 7, 8, 6 });
            Node.printNodes(partition(9, l));
            Console.Read();
        }

        static Node partition(int n, Node head)
        {
            Node pointer = head;
            Node sHead = new Node(-1);
            Node bHead = new Node(-1);
            Node sPointer = sHead;
            Node bPointer = bHead;
            while (pointer != null)
            {
                if (pointer.data >= n)
                {
                    bPointer.next = pointer;
                    bPointer = bPointer.next;
                }
                else
                {
                    sPointer.next = pointer;
                    sPointer = sPointer.next;
                }
                pointer = pointer.next;
            }
            bPointer.next = null;//Important!
            sPointer.next = bHead.next;
            return sHead.next;
        }

    }
}
