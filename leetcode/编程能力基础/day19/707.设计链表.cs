public class ListNode
{
    public int val;
    public ListNode next;

}
public class MyLinkedList
{
    /*get(index)：获取链表中第 index 个节点的值。如果索引无效，则返回-1。
    addAtHead(val)：在链表的第一个元素之前添加一个值为 val 的节点。插入后，新节点将成为链表的第一个节点。
    addAtTail(val)：将值为 val 的节点追加到链表的最后一个元素。
    addAtIndex(index,val)：在链表中的第 index 个节点之前添加值为 val  的节点。如果 index 等于链表的长度，则该节点将附加到链表的末尾。
    如果 index 大于链表长度，则不会插入节点。如果index小于0，则在头部插入节点。
    deleteAtIndex(index)：如果索引 index 有效，则删除链表中的第 index 个节点。

    来源：力扣（LeetCode）
    链接：https://leetcode.cn/problems/design-linked-list
    著作权归领扣网络所有。商业转载请联系官方授权，非商业转载请注明出处。*/
    public int size;
    ListNode head;
    ListNode tail;
    public MyLinkedList()//就是普通的链表
    {
        head = new ListNode();//头指针
        tail = new ListNode();
        head.next = tail;
        size = 0;//size更新
    }

    public int Get(int index)
    {
        if (index >= size||index<0) return -1;
        ListNode curr = head;
        for (int i = 0; i <= index; i++)//停在index处
        {
            curr = curr.next;
        }
        return curr.val;
    }

    public void AddAtHead(int val)
    {
        ListNode temp = new ListNode();
        temp.val = val;
        temp.next = head.next;
        head.next = temp;
        size++;
    }

    public void AddAtTail(int val)
    {
        tail.val = val;
        tail.next = new ListNode();
        tail = tail.next;//保持tail是空指针
        size++;
    }

    public void AddAtIndex(int index, int val)
    {
        if (index == size) AddAtTail(val);
        else if (index < 0) AddAtHead(val);
        else if (index > size) return;
        else
        {
            ListNode temp = new ListNode();
            temp.val = val;
            ListNode curr = head;
            for (int i = 0; i < index; i++)//停在前一位
                curr = curr.next;
            temp.next = curr.next;
            curr.next = temp;
            size++;
        }
    }

    public void DeleteAtIndex(int index)
    {
        if(index<0||index>=size) return ;
        ListNode curr = head;
        for (int i = 0; i < index; i++)//停在index前
            curr = curr.next;
        curr.next = curr.next.next;
        size--;
    }
}

/**
 * Your MyLinkedList object will be instantiated and called as such:
 * MyLinkedList obj = new MyLinkedList();
 * int param_1 = obj.Get(index);
 * obj.AddAtHead(val);
 * obj.AddAtTail(val);
 * obj.AddAtIndex(index,val);
 * obj.DeleteAtIndex(index);
 */