//Definition for singly-linked list.
  public class ListNode {
      public int val;
      public ListNode next;
      public ListNode(int x) { val = x; }
  }

public class Solution1 {
    public ListNode DeleteNode(ListNode head, int val) {
        ListNode before=head;
        if(head.val==val)
        {
            before=head.next;
            head.next=null;
            return before;
        }
        ListNode curr=head;
        while(curr.val!=val)
        {
            before=curr;
            curr=curr.next;
        }
        before.next=curr.next;
        curr.next=null;
        return head;
    }
}