class program{
    static void Main(string[]args)
    {
        int[] value1 = new int[] { 1,2,4 };
        ListNode list1 = new ListNode();
        ListNode temp = list1;
        for (int i = 0; i < value1.Length-1; i++)
        {
            temp.val = value1[i];
            temp.next = new ListNode();
            temp = temp.next;
        }
        temp.next=null;temp.val=value1[value1.Length-1];

         int[] value2 = new int[] { 1,3,4 };
        ListNode list2 = new ListNode();
        temp = list2;
        for (int i = 0; i < value2.Length-1; i++)
        {
            temp.val = value2[i];
            temp.next = new ListNode();
            temp = temp.next;
        }
        temp.next=null;temp.val=value2[value2.Length-1];
        Solution s=new Solution();
        s.MergeTwoLists2(list1,list2);
    }
}


