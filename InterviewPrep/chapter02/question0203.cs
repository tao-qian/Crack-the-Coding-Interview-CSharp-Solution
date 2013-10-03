using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPrep.chapter02
{
    class question0203
    {

        static void delete(Node n)
        {
            if (n == null || n.next == null)
                return;
            n.data = n.next.data;
            n.next = n.next.next;
        }
    }
}
