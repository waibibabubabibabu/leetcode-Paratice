
//  Definition for a binary tree node.
public class TreeNode
{
    public int val;
    public TreeNode left;
    public TreeNode right;
    public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
    {
        this.val = val;
        this.left = left;
        this.right = right;
    }
}

public class Solution1
{
    public TreeNode InvertTree(TreeNode root)
    {
        if(root!=null)
        {
            TreeNode tmp=root.right;
            root.right=root.left;
            root.left=tmp;
            InvertTree(root.right);InvertTree(root.left);
        }
        return root;
    }
}