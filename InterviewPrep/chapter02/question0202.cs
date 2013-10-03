using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPrep.chapter02
{
    class question0202
    {
        static void NotMain(String[] args)
        {
            Node t = Node.createLinkedList(new int[] {0 });
            Node.printNodes(t);
            Console.WriteLine(kthToLast(1,t));
            Console.Read();
        }

        static int kthToLast(int k, Node head)
        {
            Node current = head;
            Node runner = head;
            for (int i = 0; i < k; i++)
            {
                if (runner == null)
                    return -1;
                runner = runner.next;
            }
            if (runner == null)
                return -1;
            while (runner.next != null)
            {
                runner = runner.next;
                current = current.next;
            }
            return current.data;
        }
    }
}
