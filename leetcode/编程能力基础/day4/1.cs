
  //Definition for singly-linked list.
  public class ListNode {
      public int val;
      public ListNode next;
      public ListNode(int val=0, ListNode next=null) {
          this.val = val;
          this.next = next;
      }
  }

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
    public bool dfs(ListNode head,TreeNode root)
    {
        if(head==null) return true;
        if(root==null) return false;
        if(root.val==head.val) return dfs(head.next,root.left)||dfs(head.next,root.right);
        else return false;
    }
    public bool IsSubPath(ListNode head, TreeNode root) {//不能用单递归，因为如果出错链表需要重置，而单递归只会将head向前一位
        if(root==null) return false;
        if(head==null) return true;
        return dfs(head,root)||IsSubPath(head,root.left)||IsSubPath(head,root.right);//后面两个就是将head置到首位
    }
}