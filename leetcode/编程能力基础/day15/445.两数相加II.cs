
//Definition for singly-linked list.

//方法一，翻转加2.两数相加
//方法二，创建队列？
public class Solution2
{
    public ListNode ReverseList(ListNode l)//官方运行程序禁用reverse
    {
        ListNode curr1 = null, curr2 = l;
        while (curr2 != null)
        {
            ListNode temp = curr2.next;
            curr2.next = curr1;
            curr1 = curr2;
            curr2 = temp;
        }
        return curr1;
    }
    public ListNode AddTwoNumbers1(ListNode l1, ListNode l2)
    {
        ListNode res = new ListNode((l1.val + l2.val) % 10);
        int jin = (l1.val + l2.val) / 10;
        ListNode resTemp = res;
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
        if (jin == 1) resTemp.next = new ListNode(1);
        return res;
    }
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
    {
        l1 = ReverseList(l1);
        l2 = ReverseList(l2);
        ListNode res = AddTwoNumbers1(l1, l2);
        res = ReverseList(res);
        return res;
    }
}
public class Solution21
{
    public ListNode AddTwoNumbers1(ListNode l1, ListNode l2)
    {
        ListNode res = new ListNode(0);//未初始化
        Stack<int> stack1 = new Stack<int>();
        while (l1 != null)
        {
            stack1.Push(l1.val);
            l1 = l1.next;
        }
        Stack<int> stack2 = new Stack<int>();
        while (l2 != null)
        {
            stack2.Push(l2.val);
            l2 = l2.next;
        }
        int temp = stack1.Pop() + stack2.Pop();
        res.val = (temp) % 10;
        int jin = temp / 10;
        //此刻的res是末尾，需要向前迭代
        while (stack1.Count > 0 && stack2.Count > 0)
        {
            temp = jin + stack1.Pop() + stack2.Pop();
            ListNode curr = new ListNode(temp % 10, res);
            jin = temp > 9 ? 1 : 0;
            res = curr;
        }
        while (stack1.Count > 0)
        {
            temp = jin + stack1.Pop();
            ListNode curr = new ListNode(temp % 10, res);
            jin = temp > 9 ? 1 : 0;
            res = curr;
        }
        while (stack2.Count > 0)
        {
            temp = jin + stack2.Pop();
            ListNode curr = new ListNode(temp % 10, res);
            jin = temp > 9 ? 1 : 0;
            res = curr;
        }
        if (jin == 1)
        {
            ListNode curr = new ListNode(1, res);
            res = curr;
        }
        return res;
    }
}