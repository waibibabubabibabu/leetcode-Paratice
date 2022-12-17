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
public class ListNode {
      public int val;
      public ListNode next;
      public ListNode(int val=0, ListNode next=null) {
          this.val = val;
          this.next = next;
      }
  }
public class Solutionwrong {
    public int targetSum;
    public int ans;
    public int PathSum(TreeNode root, int targetSum) {
        //自底向上，也是一样，会重复计算
        //是否需要一个数据结构来存储信息
        this.targetSum=targetSum;
        this.ans=0;
        ListNode list=new ListNode();
        depth(root,list);
        return ans;
    }
    public void depth(TreeNode root,ListNode list)
    {
        if(root==null) return;
        ListNode curr=list;
        while(curr!=null){
            curr.val+=root.val;
            if(curr.val==targetSum) ans++;
            curr=curr.next;
        }
        curr=new ListNode(root.val,null);
        depth(root.left,list);
        depth(root.right,list);
    }
}
public class Solution {
    public int PathSum(TreeNode root, int targetSum) {
        //递归写法，在向下遍历的同时计算
        if(root==null) return 0;
        int ret=rootSum(root,targetSum);//有root.val参与的路径有多少条，也反映在rootsum的target-val处
        ret+=PathSum(root.left,targetSum);
        ret+=PathSum(root.right,targetSum);
        return ret;
    }
    public int rootSum(TreeNode root,long targetSum)
    {
        if(root==null) return 0;
        int val=root.val;
        int ret=0;
        if(val==targetSum) ret++;
        ret+=rootSum(root.left,targetSum-val);
        ret+=rootSum(root.right,targetSum-val);
        return ret;
    }
}
public class Solutioncopy {//前缀和解法
    public int PathSum(TreeNode root, int targetSum) {
        Dictionary<long, int> prefix = new Dictionary<long, int>();
        prefix.Add(0, 1);
        return DFS(root, prefix, 0, targetSum);
    }

    public int DFS(TreeNode root, Dictionary<long, int> prefix, long curr, int targetSum) {
        if (root == null) {
            return 0;
        }

        int ret = 0;
        curr += root.val;

        prefix.TryGetValue(curr - targetSum, out ret);
        if (prefix.ContainsKey(curr)) {
        //这里是处理重复路径，如果有重复的前缀和的话，比如有两条路径的和都是2，那么key=2的val值就是2，
        //如果将来能成立的话，ret需要加2而不是1
            ++prefix[curr];
        } else {
            prefix.Add(curr, 1);
        }
        ret += DFS(root.left, prefix, curr, targetSum);
        ret += DFS(root.right, prefix, curr, targetSum);
        --prefix[curr];//减去curr，表示这个结点已经处理完了

        return ret;
    }
}