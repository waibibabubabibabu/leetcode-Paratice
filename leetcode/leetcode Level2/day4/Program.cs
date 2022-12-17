class program
{
    static void Main()
    {
        Solution s = new Solution();
        int[] val = new int[] { -1,5,3,4,0};
        ListNode head = new ListNode();
        ListNode curr = head;
        for (int i = 0; i < val.Length-1; i++)
        {
            curr.val = val[i];
            curr.next = new ListNode();
            curr = curr.next;
        }
        curr.val=val[val.Length-1];
        s.SortListcopy(head);
    }
}