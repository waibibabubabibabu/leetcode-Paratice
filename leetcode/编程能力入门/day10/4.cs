using System;
public class Solution4 {
    public int SumOfLeftLeaves(TreeNode root) {
        if(root.left!=null&&root.right!=null) {
            if(root.left.left==null&&root.left.right==null) return root.left.val+SumOfLeftLeaves(root.left)+SumOfLeftLeaves(root.right);
            else return SumOfLeftLeaves(root.left)+SumOfLeftLeaves(root.right);
        }
        else if (root.left!=null) {
            if(root.left.left==null&&root.left.right==null) return root.left.val+SumOfLeftLeaves(root.left);
            else return SumOfLeftLeaves(root.left);}
        else if(root.right!=null)return SumOfLeftLeaves(root.right);
        return 0;
        }
}