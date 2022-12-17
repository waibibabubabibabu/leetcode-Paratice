class program
{
    public static void Main(string[] args)
    {
        MyCircularQueue circularQueue = new MyCircularQueue(3); // 设置长度为 3
        circularQueue.EnQueue(1);  // 返回 true
        circularQueue.EnQueue(2);  // 返回 true
        circularQueue.EnQueue(3);  // 返回 true
        circularQueue.EnQueue(4);  // 返回 false，队列已满
        circularQueue.Rear();  // 返回 3
        circularQueue.IsFull();  // 返回 true
        circularQueue.DeQueue();  // 返回 true
        circularQueue.EnQueue(4);  // 返回 true
        circularQueue.Rear();  // 返回 4

    }
}