class program{
    static void Main(string []args)
    {
        Solution21 s21=new Solution21 ();
        int[]val1=new int[]{2,4,3};
        ListNode l1=new ListNode(val1[0]);
        ListNode l1curr=l1;
        for(int i=1;i<val1.Length;i++)
        {
            l1curr.next=new ListNode(val1[i]);
            l1curr=l1curr.next;
        }
        int[]val2=new int[]{5,6,4};
        ListNode l2=new ListNode(val2[0]);
        ListNode l2curr=l2;
        for(int i=1;i<val2.Length;i++)
        {
            l2curr.next=new ListNode(val2[i]);
            l2curr=l2curr.next;
        }
        s21.AddTwoNumbers1(l1,l2);
    }
}