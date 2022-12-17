
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
    public void ReorderList(ListNode head)//快慢指针能用吗,只存后半部分
    {
        Stack<ListNode> stack = new Stack<ListNode>();//不让存储，显示超出了内存范围，那就
        ListNode quick = head, slow = head;
        while (quick != null && quick.next != null)
        {
            quick = quick.next.next;
            slow = slow.next;
        }
        ListNode tail = slow;
        ListNode tailfollow;
        while (tail != null)
        {
            stack.Push(tail);
            tailfollow = tail;
            tail = tail.next;
            tailfollow.next = null;
        }
        ListNode temp = head;
        ListNode tempfollow;
        ListNode temphead = head;
        while (stack.Count > 0)//还要取消原来的指针
        {
            tempfollow = temp;
            temp = temp.next;
            tempfollow.next = null;
            //赋值
            temphead.next = stack.Pop();
            temphead.next.next = temp;
            if (temphead.next.next != null) temphead = temphead.next.next;
        }

    }
    public ListNode parent;
    public void ReorderList2(ListNode head)//先快慢，再翻转（不用栈表，用迭代），最后再合并
    {
        if (head == null) return;
        ListNode quick = head, slow = head;
        while (quick != null && quick.next != null)
        {
            quick = quick.next.next;
            slow = slow.next;
        }
        ListNode temp = slow;
        slow = slow.next;
        temp.next = null;
        //链表的题一定一定先画图在写程序
        ListNode list2Head = slow;//链表翻转在于将链表的next指针翻转
        ListNode curr1 = null;
        ListNode curr2 = list2Head;
        while (curr2 != null)
        {
            temp = curr2.next;
            curr2.next = curr1;
            //向后递归
            curr1 = curr2;
            curr2 = temp;
        }
        list2Head = curr1;
        mergeList(head, list2Head);
    }
    void mergeList(ListNode l1, ListNode l2)//如果不想用·curr，要让l1的长度更长，
    //长度差为1，且list1更长，就不用curr做后续处理
    {
        ListNode temp1, temp2;
        //ListNode curr=new ListNode();
        while (l2 != null&&l1 != null  )//一下连两次
        {
            /*if (l1 == null) curr = l1;
            else curr = l2;*/
            temp1 = l1.next;
            temp2 = l2.next;
            l1.next = l2;
            l1 = temp1;
            l2.next = l1;
            l2 = temp2;
        }
        /*if(l1==null&&l2==null&&curr==null) return ;
        else if(l1!=null) curr.next=l1;
        else curr.next=l2; */
    }
}
public class Solutioncopy {
    public void ReorderList(ListNode head) {
        if (head == null) {
            return;
        }
        ListNode fast = head, slow = head;
        while (fast.next != null && fast.next.next != null) {
            fast = fast.next.next;
            slow = slow.next;
        }
        ListNode rightHead = slow.next;
        slow.next = null;
        ListNode prev = null, curr = rightHead;
        while (curr != null) {
            ListNode next = curr.next;
            curr.next = prev;
            prev = curr;
            curr = next;
        }
        ListNode node1 = head, node2 = prev;
        while (node1 != null && node2 != null) {
            ListNode temp1 = node1.next, temp2 = node2.next;
            node1.next = node2;
            node1 = temp1;
            node2.next = node1;
            node2 = temp2;
        }
    }
}