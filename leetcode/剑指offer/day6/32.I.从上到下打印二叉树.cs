//  Definition for a binary tree node.
public class TreeNode
{
    public int val;
    public TreeNode left;
    public TreeNode right;
    public TreeNode(int x) { val = x; }
}
public class Solution1
{
    public int[] LevelOrder(TreeNode root)
    {
        Queue<TreeNode> queue=new Queue<TreeNode>();
        List<int> ans=new List<int>();
        if(root==null) return ans.ToArray();
        queue.Enqueue(root);
        while (queue.Count!=0)
        {
            int Count=queue.Count;
            while(Count--!=0)
            {
                TreeNode tmp=queue.Dequeue();
                ans.Add(tmp.val);
                if(tmp.left!=null) queue.Enqueue(tmp.left);
                if(tmp.right!=null) queue.Enqueue(tmp.right);
            }
        }
        return ans.ToArray();
    }
}