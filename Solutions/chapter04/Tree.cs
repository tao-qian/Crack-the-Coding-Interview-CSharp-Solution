using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPrep.chapter04
{
    class Tree
    {
    }
    class Node
    {
        public Node left;
        public Node right;
        public Node parent;

        public int data;

        public Node(int data)
        {
            left = new Node();
            right = new Node();
            parent = new Node();
            this.data = data;
        }

        public Node():this(-1)
        {
 
        }
    }
}
