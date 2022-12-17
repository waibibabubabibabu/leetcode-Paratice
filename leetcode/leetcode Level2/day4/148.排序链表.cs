
public class Solution
{
    public ListNode SortList1(ListNode head)
    {//主要是排序方法的选择
     //交换的不一定是结点，也可以交换结点的值'
     //根据链表的特性，不能从后往前遍历
     //插排(被官方背刺)
        ListNode min = head;
        ListNode curr1 = head;
        ListNode curr2 = head;
        while (curr1 != null)
        {
            min = curr1;
            curr2 = curr1.next;
            while (curr2 != null)
            {
                if (min.val > curr2.val) min = curr2;
                curr2 = curr2.next;
            }
            int tmp = curr1.val;
            curr1.val = min.val;
            min.val = tmp;
            curr1=curr1.next;
        }
        return head;
    }
    public ListNode SortList(ListNode head)//快排，但是不适合链表
    //适合链表的，nlogn的排序方法是归并排序
    //有递归栈的存在，空间复杂度是O（logn)
    {
        return sortlist(head,null);
    }
    public ListNode sortlist(ListNode head,ListNode tail)
    {
        if(head==null) return head;
        if(head.next==tail) //后半是不会进入此条件，因为tail是null
        {
            head.next=null;
            return head;
        }
        ListNode quick=head,slow=head;
        while(quick!=tail&&quick.next!=tail)
        {
            quick=quick.next.next;
            slow=slow.next;
        }
        ListNode mid=slow;
        //slow.next=null;//断开
        ListNode list1=sortlist(head,mid);
        ListNode list2=sortlist(mid,tail);
        ListNode sorted=merge(list1,list2);
        return sorted;
    }
    public ListNode merge(ListNode l1,ListNode l2)
    {
        ListNode dummyhead=new ListNode(0);//表头？
        ListNode temp=dummyhead,temp1=l1,temp2=l2;
        while(temp1!=null&&temp2!=null)
        {
            if(temp1.val<temp2.val)
            {
                temp.next=temp1;
                temp1=temp1.next;
            }
            else {
                temp.next=temp2;
                temp2=temp2.next;
            }
            temp=temp.next;
        }
        if(temp1!=null) temp.next=temp1;//后面自动续上了
        if(temp2!=null) temp.next=temp2;
        return dummyhead.next;
    }
    public ListNode SortListcopy(ListNode head) {//非递归式写法
        if (head == null) {
            return head;
        }
        int length = 0;
        ListNode node = head;
        while (node != null) {
            length++;
            node = node.next;
        }//判断链表的长度
        ListNode dummyHead = new ListNode(0, head);//表头
        for (int subLength = 1; subLength < length; subLength <<= 1) {
            ListNode prev = dummyHead, curr = dummyHead.next;
            while (curr != null) {
                ListNode head1 = curr;
                for (int i = 1; i < subLength && curr.next != null; i++) {
                    curr = curr.next;
                }
                ListNode head2 = curr.next;
                curr.next = null;//head1在这里断开
                curr = head2;
                for (int i = 1; i < subLength && curr != null && curr.next != null; i++) {
                    curr = curr.next;
                }
                ListNode next = null;
                if (curr != null) {
                    next = curr.next;
                    curr.next = null;
                }
                ListNode merged = merge(head1, head2);
                prev.next = merged;
                while (prev.next != null) {
                    prev = prev.next;
                }
                curr = next;
            }
        }
        return dummyHead.next;
    }
}