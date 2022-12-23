//Definition for a binary tree node.
  public class TreeNode {
      public int val;
      public TreeNode left;
      public TreeNode right;
      public TreeNode(int x) { val = x; }
  }
public class Solution2 {
    public TreeNode MirrorTree(TreeNode root) {
        if(root==null) return null;
        TreeNode left=MirrorTree(root.left);
        TreeNode right=MirrorTree(root.right);
        //在这里完成交换
        root.right=left;
        root.left=right;
        return root;
    }
}