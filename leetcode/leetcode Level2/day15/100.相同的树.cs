//  Definition for a binary tree node.
  public class TreeNode {
      public int val;
      public TreeNode left;
      public TreeNode right;
      public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
          this.val = val;
          this.left = left;
          this.right = right;
      }
  }
public class Solution1 {
    public bool IsSameTree(TreeNode p, TreeNode q) {
        if(p!=null&&q!=null)
        {
            if(p.val!=q.val) return false;
            return IsSameTree(q.left,p.left)&&IsSameTree(q.right,p.right);
        }
        else if(p==null&&q==null) return true;
        else return false;
    }
}