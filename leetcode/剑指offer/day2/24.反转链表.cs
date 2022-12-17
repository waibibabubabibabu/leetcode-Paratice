/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
public class Solution2 {
    public ListNode ReverseList(ListNode head) {
        ListNode curr1=null;
        ListNode curr2=head;
        while(curr2!=null)
        {
            ListNode tmp=curr2.next;
            curr2.next=curr1;
            curr1=curr2;
            curr2=tmp;
        }
        return curr1;
    }
}