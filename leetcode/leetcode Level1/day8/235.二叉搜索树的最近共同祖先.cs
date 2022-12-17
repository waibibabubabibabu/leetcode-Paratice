public class Solution {
    public TreeNode LowestCommonAncestor(TreeNode root, TreeNode p, TreeNode q) {
        //根据二叉搜索树的性质
        int right=Math.Max(p.val,q.val);
        int left=Math.Min(p.val,q.val);
        TreeNode res=dfs(root,left,right);
        return res;
    }
    public TreeNode dfs(TreeNode root,int left,int right)
    {
        if(root==null) return null;
        if(left<=root.val&&root.val<=right) return root;
        else if(root.val>right) return dfs(root.left,left,right);
        else return dfs(root.right,left,right);
    }
}