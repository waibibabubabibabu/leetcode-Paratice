public class MyCircularQueue
{
    int[] circleQueue;//用数组实现就行
    int front;//队首
    int rear;//队尾
    int len;
    //如果不想设两个bool来区分的话，可以创建一个长度为k+1的数组，这样可以实现两个is的区分
    bool isempty;//需要区分rear==front，在入队，出队的同时完成判断
    bool isfull;
    public MyCircularQueue(int k)
    {
        circleQueue = new int[k];
        front = 0; rear = 0; len = k;
        isempty = true;
        isfull = false;
    }

    public bool EnQueue(int value)
    {
        if (IsFull() == true) return false;
        isempty=false;
        circleQueue[rear] = value;
        rear = (rear + 1) % len;
        if(rear==front) isfull=true;
        else isfull=false;
        return true;
    }

    public bool DeQueue()
    {
        if (IsEmpty() == true) return false;
        isfull=false;
        front = (front + 1) % len;
        if(rear==front) isempty=true;
        else isempty=false;
        return true;
    }

    public int Front()
    {
        if(IsEmpty()==true) return -1;
        return circleQueue[front];
    }

    public int Rear()
    {
        if(IsEmpty()==true) return -1;
        int temp=(rear+len-1)%len;
        return circleQueue[temp];
    }

    public bool IsEmpty()
    {
        return isempty;
    }

    public bool IsFull()
    {
        return isfull;
    }
}

/**
 * Your MyCircularQueue object will be instantiated and called as such:
 * MyCircularQueue obj = new MyCircularQueue(k);
 * bool param_1 = obj.EnQueue(value);
 * bool param_2 = obj.DeQueue();
 * int param_3 = obj.Front();
 * int param_4 = obj.Rear();
 * bool param_5 = obj.IsEmpty();
 * bool param_6 = obj.IsFull();
 */