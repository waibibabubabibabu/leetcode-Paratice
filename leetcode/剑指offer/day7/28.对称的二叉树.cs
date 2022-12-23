/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int x) { val = x; }
 * }
 */
public class Solution {
    public bool IsSymmetric(TreeNode root) {
        //dfs
        return check(root,root);
    }
    public bool check(TreeNode p,TreeNode q)
    {
        if(q==null&&p==null) return true;
        if(q==null||p==null) return false;
        return q.val==p.val&&check(p.left,q.right)&&check(q.left,p.right);
    }
}