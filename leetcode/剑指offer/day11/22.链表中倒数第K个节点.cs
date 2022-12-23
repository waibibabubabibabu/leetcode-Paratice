/*
 * @Author: 歪比巴布 1578628870@qq.com
 * @Date: 2022-12-23 11:13:00
 * @LastEditTime: 2022-12-23 11:19:26
 * 个人学习用
 */

/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
public class Solution
{
    public ListNode GetKthFromEnd(ListNode head, int k){
        //法二,快慢指针，快指针先出发k次
        ListNode slow=head,fast=head;
        for(int i=0;i<k;i++)
        {
            fast=fast.next;
        }
        while(fast!=null)
        {
            slow=slow.next;
            fast=fast.next;
        }
        return slow;
    }
    public ListNode GetKthFromEnd(ListNode head, int k)
    {
        //法一，先统计数量，再返回
        ListNode curr = head;
        int count=0;
        while (curr != null)
        {
            count++;
            curr = curr.next;
        }
        curr=head;
        for(int i=0;i<count-k;i++)
        {
            curr=curr.next;
        }
        return curr;
    }
}