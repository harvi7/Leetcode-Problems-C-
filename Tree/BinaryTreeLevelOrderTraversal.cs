public class Solution {
    public IList<IList<int>> LevelOrder(TreeNode root) {
        var res = new List<IList<int>>();
        if (root == null)
            return res;
        var q = new Queue<TreeNode>();
        q.Enqueue(root);
        while (q.Count > 0)
        {
            var size = q.Count;
            var level = new List<int>();
            for (var i = 0; i < size; i++)
            {
                var n = q.Dequeue();
                level.Add(n.val);
                if (n.left != null) q.Enqueue(n.left);
                if (n.right != null) q.Enqueue(n.right);
            }
            res.Add(level);
        }
        return res;
    }
}