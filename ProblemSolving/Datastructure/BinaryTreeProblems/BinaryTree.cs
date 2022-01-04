using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datastructure.BinaryTreeProblems
{
    public class BinaryTree
    {
        public void PreorderTraversal(TreeNode root)
        {
            if (root == null)
                return;
            Console.Write(root.val);

            PreorderTraversal(root.left);
            PreorderTraversal(root.right);
        }
    }
}
