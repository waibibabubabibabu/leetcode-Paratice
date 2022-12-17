class program{
    static void Main(string[] args)
    {
        int[]val1=new int[]{1,2,3,4,5};
        ListNode l1=new ListNode(val1[0]);
        ListNode l1curr=l1;
        for(int i=1;i<val1.Length;i++)
        {
            l1curr.next=new ListNode(val1[i]);
            l1curr=l1curr.next;
        }
        Solution1 s1=new Solution1();
        s1.RotateRight(l1,4);
    }
}