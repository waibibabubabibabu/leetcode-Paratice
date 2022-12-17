public class Solution2
{
    public ListNode DetectCycle(ListNode head)
    {
        if (head == null) return null;
        HashSet<ListNode> hash = new HashSet<ListNode>();
        ListNode curr = head;
        while (true)
        {
            if (hash.Contains(curr) == false) hash.Add(curr);
            else return curr;
            if (curr.next == null) return null;
            curr = curr.next;
        }
    }

    public ListNode detectCycle(ListNode head) {//官方题解，双指针
        if (head == null) {
            return null;
        }
        ListNode slow = head, fast = head;
        while (fast != null) {
            slow = slow.next;
            if (fast.next != null) {
                fast = fast.next.next;
            } else {
                return null;
            }
            if (fast == slow) {//一定会在环内相遇，通过计算
                ListNode ptr = head;//详细数据见截图
                while (ptr != slow) {
                    ptr = ptr.next;
                    slow = slow.next;
                }
                return ptr;
            }
        }
        return null;
    }


/*作者：LeetCode-Solution
链接：https://leetcode.cn/problems/linked-list-cycle-ii/solution/huan-xing-lian-biao-ii-by-leetcode-solution/
来源：力扣（LeetCode）
著作权归作者所有。商业转载请联系作者获得授权，非商业转载请注明出处。*/
}