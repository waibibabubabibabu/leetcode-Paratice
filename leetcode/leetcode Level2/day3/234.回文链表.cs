public class Solution
{
    public bool IsPalindrome(ListNode head)
    {
        ListNode quick = head;
        ListNode slow = head;
        Stack<ListNode> stack = new Stack<ListNode>();
        //如果希望降低空间复杂度，可以将前半部分的链表翻转
        while (quick != null && quick.next != null)
        {
            stack.Push(slow);
            //或者执行链表翻转的操作
            slow = slow.next;
            quick = quick.next.next;
        }
        if (quick != null) slow = slow.next; //奇数,slow需要向前移动1位
        while (slow != null && stack.Count != 0)
        {
            if (slow.val != stack.Pop().val) return false;
            slow=slow.next;
        }
        return true;
    }
}