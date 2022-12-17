using System;

  //Definition for singly-linked list.
 
public class Solution2 {
    public ListNode MiddleNode(ListNode head) {
        ListNode temp=head;
        int index=0;
        while(temp!=null)
        {
            temp=temp.next;
            index++;
        }
        int middle=index/2;
        index=0;
        while(index!=middle)
        {
            head=head.next;
            index++;
        }
        return head;
    }
    public ListNode MiddleNodeQuickSlow(ListNode head) {
    ListNode quick=head;
    ListNode slow=head;
    while(quick!=null&&/**/quick.next!=null)//判断条件少了一个，不然会报错，说对象未实例化
    {
        quick=quick.next.next;
        slow=slow.next;
    }
    return slow;
    }
}