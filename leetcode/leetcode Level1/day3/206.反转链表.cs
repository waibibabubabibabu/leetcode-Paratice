/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */
public class Solution {
    public ListNode ReverseList(ListNode head) {
        ListNode temp1=null;
        ListNode temp2=head;
        while(temp2!=null)
        {
            ListNode temp=temp2.next;
            temp2.next=temp1;
            temp1=temp2;
            temp2=temp;
        }
        return temp1;
    }
}