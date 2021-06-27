public class Solution {
    
    public static Dictionary<int,int> map = null;
    public Solution() => map = new Dictionary<int,int>();
    
    public TreeNode BuildTree(int[] preorder, int[] inorder) {
        for (int i = 0; i < inorder.Length;i++) 
            map.Add(inorder[i], i);
        int preorderIndex = 0;
        return helper(inorder, preorder, 0, inorder.Length - 1, ref preorderIndex);
    }
    
    public static TreeNode helper(int[] inorder, int[] preorder, int pLeft, int pRight, ref int preorderIndex)
    {
        if (pLeft > pRight) return null;
        var indexInInOrder = map[preorder[preorderIndex]];
        TreeNode root = new TreeNode(preorder[preorderIndex++]);
        root.left = helper(inorder,preorder,pLeft,indexInInOrder - 1, ref preorderIndex);
        root.right = helper(inorder,preorder,indexInInOrder + 1,pRight, ref preorderIndex);
        return root;
    }
}