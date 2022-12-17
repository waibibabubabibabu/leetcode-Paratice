
//Definition for singly-linked list.
public class ListNode
{
    public int val;
    public ListNode next;
    public ListNode(int val = 0, ListNode next = null)
    {
        this.val = val;
        this.next = next;
    }
}

public class Solution1
{
    public ListNode RotateRight(ListNode head, int k)
    {
        if(head==null) return head;
        int len = 0;
        ListNode curr = head;
        while (curr.next != null) { curr = curr.next; len++; }
        len++;
        if (k % len == 0) return head;
        ListNode tail = curr;
        int cutIndex = len-k % len-1;;
        ListNode cutNode = head;
        for (int i = 0; i < cutIndex; i++) cutNode = cutNode.next;
        ListNode temp = cutNode.next;
        cutNode.next = null;
        tail.next = head;
        head = temp;
        return head;

    }
}