public class Solution2
{
    public IList<IList<int>> LevelOrder(TreeNode root)
    {

        Queue<TreeNode> queue = new Queue<TreeNode>();
        IList<IList<int>> ans = new List<IList<int>>();
        if (root == null) return ans;
        queue.Enqueue(root);
        while (queue.Count != 0)
        {
            int Count = queue.Count;
            IList<int> ansTmp = new List<int>();
            while (Count-- != 0)
            {
                TreeNode tmp = queue.Dequeue();
                ansTmp.Add(tmp.val);
                if (tmp.left != null) queue.Enqueue(tmp.left);
                if (tmp.right != null) queue.Enqueue(tmp.right);
            }
            ans.Add(ansTmp);
        }
        return ans;
    }
}