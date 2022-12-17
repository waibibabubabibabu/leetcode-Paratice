
public class Solution {
    public bool IsBalanced(TreeNode root) {
        if(root==null) return true;
        else if(Math.Abs(Height(root.right)-Height(root.left))>1) return false;
        else return IsBalanced(root.right)&&IsBalanced(root.left);

    }
    public int Height(TreeNode root)
    {
        if(root==null) return 0;
        else return Math.Max(Height(root.left),Height(root.right))+1;
    }
}
class Solutioncopy {//自底向上递归可以减少高度的计算
    public bool isBalanced(TreeNode root) {
        return height(root) >= 0;
    }

    public int height(TreeNode root) {
        if (root == null) {
            return 0;
        }
        int leftHeight = height(root.left);
        int rightHeight = height(root.right);
        if (leftHeight == -1 || rightHeight == -1 || Math.Abs(leftHeight - rightHeight) > 1) {
            return -1;
        } else {
            return Math.Max(leftHeight, rightHeight) + 1;
        }
    }
}
