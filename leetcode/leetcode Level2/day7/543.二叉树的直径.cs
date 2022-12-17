//Definition for a binary tree node.
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
    //Stack<TreeNode> stack;
    int maxlen = 1;
    public int DiameterOfBinaryTree(TreeNode root)
    {//递归被背刺了，不行
     //超时是因为本来调用一次就可以的，调用了两次
     //遍历所有的结点，从左到右
        Diameter(root);
        return maxlen - 1;
    }

    public int Diameter(TreeNode root)
    {
        if (root == null) return 0;
        int ans1 = Diameter(root.right);
        int ans2 = Diameter(root.left);
        maxlen = Math.Max(ans1 + ans2 + 1, maxlen);
        int maxsidelen = Math.Max(ans1, ans2) + 1;
        return maxsidelen;
    }
}