
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
     public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
    {
        ListNode res = new ListNode((l1.val + l2.val)%10);
        int jin=(l1.val + l2.val)/10;
        ListNode resTemp=res;
        l1 = l1.next; l2 = l2.next;
        while (l1 != null && l2 != null)
        {
            resTemp.next = new ListNode((l1.val + l2.val + jin) % 10);
            if (l1.val + l2.val + jin > 9) jin = 1;
            else jin = 0;
            l1 = l1.next; l2 = l2.next; resTemp = resTemp.next;
        }
        while (l1 != null)
        {
            resTemp.next = new ListNode((l1.val + jin) % 10);
            if (l1.val + jin > 9) jin = 1;
            else jin = 0;
            l1 = l1.next; resTemp = resTemp.next;
        }
        while (l2 != null)
        {
            resTemp.next = new ListNode((l2.val + jin) % 10);
            if (l2.val + jin > 9) jin = 1;
            else jin = 0;
            l2 = l2.next; resTemp = resTemp.next;
        }
        if(jin==1) resTemp.next=new ListNode(1);
        return res;
    }
}