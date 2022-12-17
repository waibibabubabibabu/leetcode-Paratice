/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */
public class Solution {
    public IList<int> RightSideView(TreeNode root) {
        IList<int> ans=new List<int>();
        if(root==null) return ans;
        //层序遍历，返回最右边的值
        Queue<TreeNode> queue=new Queue<TreeNode>();
        queue.Enqueue(root);
        //ans.Add(1);
        while(queue.Count!=0)
        {
            int count=queue.Count;
            while(count!=0)
            {
                TreeNode tmp=queue.Dequeue();
                count--;
                if(count==0) ans.Add(tmp.val);
                if(tmp.left!=null) queue.Enqueue(tmp.left);
                if(tmp.right!=null) queue.Enqueue(tmp.right);
            }
        }
        return ans;
        /*TreeNode curr=root;
        while(curr!=null)
        {
            ans.Add(curr.val);
            if(curr.right!=null) curr=curr.right;
            else curr=curr.left;
        }*/
    }
}