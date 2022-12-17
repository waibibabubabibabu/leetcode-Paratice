using System;
class program
{
    public static void Main(string[] args)
    {
        MyLinkedList linkedList = new MyLinkedList();
        linkedList.AddAtHead(1);
        linkedList.AddAtTail(3);
        linkedList.AddAtIndex(1, 2);   //链表变为1-> 2-> 3
        int res=linkedList.Get(1);            //返回2
        linkedList.DeleteAtIndex(1);  //现在链表是1-> 3
        res=linkedList.Get(1);            //返回3
    }
}