//Definition for singly-linked list.
  public class ListNode {
      public int val;
      public ListNode next;
      public ListNode(int x) { val = x; }
  }
 
public class Solution1 {
    public int[] ReversePrint(ListNode head) {
        //不能改变原链表的情况下
        Stack<int> stack=new Stack<int>();
        while(head!=null){
            stack.Push(head.val);
            head=head.next;
        }
        return stack.ToArray();
    }
}