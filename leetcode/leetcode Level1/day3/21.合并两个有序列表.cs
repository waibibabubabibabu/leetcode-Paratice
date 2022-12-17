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
    public ListNode MergeTwoLists(ListNode list1, ListNode list2)
    {
        if (list1 == null) return list2;
        if (list2 == null) return list1;
        ListNode listReturn, listElse;
        if (list1.val < list2.val)
        {
            listReturn = list1; listElse = list2;
        }
        else
        {
            listReturn = list2; listElse = list1;
        }
        ListNode curr1 = listReturn, curr2 = listElse;
        while (curr1.next != null && curr2 != null)
        {
            ListNode curr1Tail = curr1.next;
            if (curr2.val > curr1Tail.val) curr1 = curr1.next;//直接下一步
            else
            {
                ListNode curr2Tail = curr2;
                while (curr2Tail.next != null && curr2Tail.next.val <= curr1Tail.val) curr2Tail = curr2Tail.next;
                ListNode temp = curr2Tail.next;//等于空出去就终止了
                curr1.next = curr2; curr2Tail.next = curr1Tail;
                curr2 = temp; curr1 = curr1Tail;
            }
        }
        //两种情况
        //一种listreturn为空
        if (curr2 != null) curr1.next = curr2;
        //第二种情况不需要处理，直接返回listreturn
        return listReturn;
    }
    public ListNode MergeTwoLists2(ListNode list1, ListNode list2)
    {//新建一个更省时间吗
        if (list1 == null) return list2;
        if (list2 == null) return list1;
        ListNode head = new ListNode();
        ListNode curr = head;
        while (list1 != null && list2 != null)
        {

            if (list1.val < list2.val) { curr.val = list1.val; list1 = list1.next; }
            else { curr.val = list2.val; list2 = list2.next; }
            curr.next = new ListNode();
            curr = curr.next;
        }
        //肯定有一个不是null
        if (list1 != null) {curr.val = list1.val;curr.next=list1.next;}
        else {curr.val = list2.val;curr.next=list2.next;}
        return head;
    }
}