
// Definition for a binary tree node.
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
    /*public bool IsValidBST(TreeNode root)//不对，右子树的所有结点都必须大于root，而不是只有右结点本身
    {
        if (root == null) return true;
        if (root.left == null && root.right == null) return true;
        if(root.left!=null&&root.right==null){
             if(root.left.val<root.val) return IsValidBST(root.left);
             else return false;
        }
        if(root.right!=null&&root.left==null)
        {
            if(root.right.val>root.val) return IsValidBST(root.right);
            else return false;
        }
        if(root.right.val>root.val&&root.left.val<root.val) return IsValidBST(root.left)&&IsValidBST(root.right);
        else return false;
        
    }*/
    int right;
    int left;
    bool isleft;
    bool isright;
    bool isinit=false;
    /*public bool IsValidBST(TreeNode root)
    {
       
        if (root == null) return true;
        if(isinit==false)
        {
            isinit=true;
            if(root.right!=null) right=root.right.val;
            if(root.left!=null) left=root.left.val;
        }
        if(root.right!=null&&root.left!=null)
        {
            if (left < root.val&&root.val<right)
            {
                right=root.val;
                isleft=IsValidBST(root.left);

                isright=IsValidBST(root.right);
                return isleft&&isright;
            }
            
            else return false;
        }
        if (root.left != null)
        {
            left = root.left.val;right=root.val;
            if (left < root.val&&root.val<right)//可以继续
                return IsValidBST(root.left);
            else return false;
        }
        if (root.right != null) {
            right = root.right.val;left=root.val;
            if(left < root.val&&root.val<right)
            return IsValidBST(root.right);
            else return false;
        }
        return true;//左右子树为空
    }*/
    //没做出来，看官方题解
    public bool IsValidBST(TreeNode root) {
        //两种方法，中序遍历，递归调用，但是设了另一个函数来，有边界的
        return isValidBST(root,long.MinValue,long.MaxValue);
    }
    public bool isValidBST(TreeNode root,long left,long right)//设出边界很方便理解了
    {
        if(root==null) return true;
        if(root.val<left||root.val>right)  return false;
        else return isValidBST(root.left,left,(long)root.val-1)&&isValidBST(root.right,(long)root.val+1,right);
    }
}