using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPrep.chapter04
{
    class question0403
    {
        public Node CreateMinBST(int[] array, int start, int end)
        {
            if (end < start)
                return null;
            int middle = (start + end) / 2;
            Node mNode = new Node(array[middle]);
            Node left = CreateMinBST(array, start, middle - 1);
            Node right = CreateMinBST(array, middle + 1, end);
            mNode.left = left;
            mNode.right = right;
            return mNode;
        }
    }
}
