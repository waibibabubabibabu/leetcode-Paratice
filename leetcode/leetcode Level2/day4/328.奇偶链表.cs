
//  Definition for singly-linked list.
  public class ListNode {
      public int val;
      public ListNode next;
      public ListNode(int val=0, ListNode next=null) {
          this.val = val;
          this.next = next;
      }
  }
 
public class Solution1 {
    public ListNode OddEvenList(ListNode head) {
        ListNode odd=head;
        if(head==null||head.next==null) return head;//不需要重新排列
        ListNode even=head.next;
        ListNode currOdd=odd;
        ListNode currEven=even;
        ListNode curr=even.next;
        int count=2;
        while(curr!=null)
        {
            if(count%2==0)//该插入奇结点
            {
                currOdd.next=curr;
                currOdd=currOdd.next;
            }  
            else{
                currEven.next=curr;
                currEven=currEven.next;
            }
            curr=curr.next;
            count++;
        }
        currEven.next=null;
        currOdd.next=even;
        return odd;
        
    }
}