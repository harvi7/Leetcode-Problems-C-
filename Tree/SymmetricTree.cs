public class Solution {
    public bool IsSymmetric(TreeNode root) {
        return root == null
            || isMirror(root.left, root.right);
    }
    
    private static bool isMirror(TreeNode leftNode, TreeNode rightNode) {
        if (leftNode == null || rightNode == null)
            return leftNode == rightNode;
        if (leftNode.val != rightNode.val)
            return false;
        return isMirror(leftNode.left, rightNode.right) && isMirror(leftNode.right, rightNode.left);
    }
}