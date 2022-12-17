
  //Definition for a binary tree node.
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
    public bool IsBalanced(TreeNode root) {//自顶向下浪费时间
        if(root==null) return true;
        if(Math.Abs(height(root.left)-height(root.right))>1) return false;
        else return IsBalanced(root.left)&&IsBalanced(root.right);
    }
    public int height(TreeNode root)
    {
        if(root==null) return 1;
        return Math.Max(height(root.left),height(root.right))+1;
    }

     public bool isBalanced1(TreeNode root) {
        return height1(root) >= 0;
    }

    public int height1(TreeNode root) {
        if (root == null) {
            return 0;
        }
        int leftheight1 = height1(root.left);//向下递归了
        int rightheight1 = height1(root.right);
        if (leftheight1 == -1 || rightheight1 == -1 || Math.Abs(leftheight1 - rightheight1) > 1) {
            return -1;
        } else {
            return Math.Max(leftheight1, rightheight1) + 1;
        }
    }
}