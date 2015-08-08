using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPrep.chapter04
{
    class qusetion0406
    {
        public static Node NextNode(Node n)
        {
            Node next;
            if (n.right != null)
            {
                next = n.right;
                while (next.left != null)
                    next = next.left;
                return next;
            }
            next = n.parent;
            Node current = n;
            while (next != null && next.right == n)
            {
                next = next.parent;
                n = n.parent;
            }
            if (next == null)
                return null;
            return next;

        }
    }
}
