using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPrep.chapter02
{
    class question0205
    {
        static void NotMain(String[] args)
        {
            Node l = Node.createLinkedList(new int[] { 9,8, 1, 7 });
            Node r = Node.createLinkedList(new int[] { 2, 9, 5 });
            Node.printNodes(addListsReverse(l, r));
            Console.Read();
        }

        static Node addLists(Node n1, Node n2, bool carry)
        {
            if (n1 == null && n2 == null && !carry)
                return null;

            int result = 0;
            if (n1 != null)
                result += n1.data;
            if (n2 != null)
                result += n2.data;
            if (carry)
                result++;

            if (result >= 10)
            {
                carry = true;
                result -= 10;
            }
            else
                carry = false;

            Node n = new Node(result);

            n.next = addLists(n1 == null ? null : n1.next, n2 == null ? null : n2.next, carry);
            return n;
        }



        static Node addListsReverse(Node n1, Node n2)
        {
            int length1 = 0;
            int length2 = 0;
            Node r1 = n1;
            Node r2 = n2;
            while (r1 != null)
            {
                length1++;
                r1 = r1.next;
            }
            while (r2 != null)
            {
                length2++;
                r2 = r2.next;
            }
            n2 = pad(length1, length2, n1, n2);
            n1 = pad(length2, length1, n2, n1);
            NodeWrapper result = addReverseRecur(n1, n2);
            if (result.carry == 1)
            {
                Node nn = new Node(1);
                nn.next = result.n;
                return nn;
            }
            else
            {
                return result.n;
            }
        }

        static NodeWrapper addReverseRecur(Node n1, Node n2)
        {
            if (n1 == null && n2 == null)
                return new NodeWrapper(0, null);

            NodeWrapper wrapper = addReverseRecur(n1.next, n2.next);
            int result = wrapper.carry + n1.data + n2.data;
            int carry = 0;
            if (result >= 10)
            {
                result -= 10;
                carry = 1;
            }
            Node current = new Node(result);
            current.next = wrapper.n;
            return new NodeWrapper(carry, current);
        }



        static Node pad(int r1, int r2, Node n1, Node n2)
        {
            if (r1 <= r2)
                return n2;
            int diff = r1 - r2;
            Node padding = new Node(0);
            Node paddingHead = padding;
            for (int i = 1; i < diff; i++)
            {
                padding.next = new Node(0);
                padding = padding.next;
            }
            padding.next = n2;
            return paddingHead;
        }

        class NodeWrapper
        {
            public int carry;
            public Node n;
            public NodeWrapper(int carry, Node n)
            {
                this.carry = carry;
                this.n = n;
            }
        }
    }
}
