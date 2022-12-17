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
    public TreeNode SortedArrayToBST(int[] nums)
    {
        return sortedtobst(nums, 0, nums.Length - 1);

    }
    public TreeNode sortedtobst(int[] nums, int left, int right)
    {
        if (left > right) return null;
        int mid = (right + left) / 2;  //mid向下取整
        TreeNode root = new TreeNode(nums[mid]);
        root.right=sortedtobst(nums,mid+1,right);
        root.left=sortedtobst(nums,left,mid-1);
        return root;
    }
}