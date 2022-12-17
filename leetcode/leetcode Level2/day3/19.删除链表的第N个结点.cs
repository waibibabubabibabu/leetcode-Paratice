// Definition for singly-linked list.
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
public class Solution1//用队列把后面n个全部存起来
{
    Queue<ListNode> queue;
    public ListNode RemoveNthFromEnd1(ListNode head, int n)
    {
        if(head.next==null) return null;
        queue = new Queue<ListNode>();
        ListNode curr = head;
        while (queue.Count < n) { queue.Enqueue(curr); curr = curr.next; }//不会遇到curr为空
        ListNode tmp=queue.Peek();
        while(curr!=null) {
            queue.Enqueue(curr);curr=curr.next;
            tmp=queue.Dequeue();
        }
        if(tmp==queue.Peek()) return head.next;
        tmp.next=tmp.next.next;
        return head;
    }
    public ListNode RemoveNthFromEnd(ListNode head, int n)
    {
        //不是用队列，使用一个listnode维护前n个即可
        ListNode first=head;
        ListNode second=head;
        for(int i=0;i<n;i++) first=first.next;//不会遇到空的情况
        if(first==null) return head.next;
        while(first.next!=null){
            second=second.next;
            first=first.next;
        }
        second.next=second.next.next;
        return head;
    }
}