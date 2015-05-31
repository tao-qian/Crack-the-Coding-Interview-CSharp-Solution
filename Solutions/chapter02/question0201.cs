using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPrep.chapter02
{
    class question0201
    {
        static void NotMain(String[] args)
        {
            Node t = Node.createLinkedList(new int[] { 1, 2, 3, 4,4,2,4,1,2,4 });
            Node.printNodes(t);
            removeDuplicateNoStorage(t);
            Node.printNodes(t);
            Console.Read();
        }

        static void removeDuplicate(Node n)
        {
            HashSet<int> set = new HashSet<int>();
            Node next = n.next;
            if(next == null)
                return;
            set.Add(n.data);

            while (next != null)
            {
                if (set.Contains(next.data))
                {
                    n.next = next.next;
                }
                else
                {
                    set.Add(next.data);
                    n = n.next;
                }
                next = next.next;
            }
        }

        static void removeDuplicateNoStorage(Node n)
        {
            Node current = n;
            while (current != null)
            {
                Node runner = current;
                while (runner.next != null)
                {
                    if (current.data == runner.next.data)
                        runner.next = runner.next.next;
                    else 
                        runner = runner.next;
                }
                current = current.next;
            }
        }

    }
}
