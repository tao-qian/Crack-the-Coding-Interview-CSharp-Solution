using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPrep.chapter04
{
    class question0401
    {
        public static int CheckHeight(Node root)
        {
            if (root == null)
                return 0;
            int leftHeight = CheckHeight(root.left);
            int rightHeight = CheckHeight(root.right);
            if (Math.Abs(leftHeight - rightHeight) >= 1)
                return -1;
            return Math.Max(leftHeight, rightHeight) + 1;
        }
    }
}
