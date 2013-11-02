using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPrep.chapter04
{
    class question0407
    {
        //Not tested.
        public Node CommonAnce(Node root, Node first, Node second)
        {
            if (root == null)
                return null;
            if (root == first)
                return first;
            if (root == second)
                return second;
            Node left = CommonAnce(root.left, first, second);
            Node right = CommonAnce(root.right, first, second);
            if (left == null)
                return right;
            else if (right == null)
                return left;
            return root;
        }
    }

}
