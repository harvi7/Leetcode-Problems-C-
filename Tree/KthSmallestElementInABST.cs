public class Solution {
    Stack<TreeNode> stack = new Stack<TreeNode>();
	
    public int KthSmallest(TreeNode root, int k) {
        TraverseToMin(root);

        TreeNode node = null;

        while(k > 0)
        {
            node = stack.Pop();
            k--;
            if (k == 0)
                break;

            TraverseToMin(node.right);
        }

        return node.val;
    }

    private void TraverseToMin(TreeNode node)
    {
        while(node != null)
        {
            stack.Push(node);
            node = node.left;
        }
    }
}