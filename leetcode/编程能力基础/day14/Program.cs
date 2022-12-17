using System;
class program
{
    static void Main(string[] args)
    {
        int[] value = new int[] { 1,2,3,4,5 };
        ListNode head = new ListNode();
        ListNode temp = head;
        for (int i = 0; i < value.Length-1; i++)
        {
            temp.val = value[i];
            temp.next = new ListNode();
            temp = temp.next;
        }
        temp.next=null;temp.val=value[value.Length-1];
        Solution1 s1 = new Solution1();
        s1.ReorderList2(head);
        /*Solutioncopy scopy=new Solutioncopy();
        scopy.ReorderList(head);*/
    }
}