public class SeatManager
{

    Queue<int> seatQueue = new Queue<int>();
    public SeatManager(int n)
    {
        for (int i = 1; i <= n; i++) seatQueue.Enqueue(i);
    }

    public int Reserve()
    {
        return seatQueue.Dequeue();
    }
    //单纯的轮换队列超出了时间限制
    //有什么方法能直接把预约的数字插入进去呢
    //用列表？优先级是自己
    public void Unreserve(int seatNumber)// 2 3 5  3 5 2   5 2 3  4入队//    2 3 4 1 最开始1就应该入队了  3 4 1 2   4 1 2 3  1 2 3 4 
    {
        if (seatQueue.Count > 0)
        {
            int minQueue = seatQueue.Peek();
            if (minQueue < seatNumber) while (seatQueue.Peek() < seatNumber) { int temp = seatQueue.Dequeue(); seatQueue.Enqueue(temp); }
            seatQueue.Enqueue(seatNumber);
            while (seatQueue.Peek() != Math.Min(minQueue, seatNumber)) { int temp = seatQueue.Dequeue(); seatQueue.Enqueue(temp); }
        }
        else
            seatQueue.Enqueue(seatNumber);
    }
}

public class SeatManager1
{

    Dictionary<int, int> seatDic = new Dictionary<int, int>();//也超时了
    int len;
    int head;
    public SeatManager1(int n)
    {
        for (int i = 1; i <= n; i++) seatDic.Add(i, 1);//有一个座位
        len = n;
        head = 1;
    }

    public int Reserve()//有超时了，预约的从头太慢了
    {
        seatDic[head]--;
        int res = head;
        while (head <= len && seatDic[head] == 0) head++;
        return res;
    }
    //单纯的轮换队列超出了时间限制
    //有什么方法能直接把预约的数字插入进去呢
    //用列表？优先级是自己
    public void Unreserve(int seatNumber)// 2 3 5  3 5 2   5 2 3  4入队//    2 3 4 1 最开始1就应该入队了  3 4 1 2   4 1 2 3  1 2 3 4 
    {
        if (seatNumber < head) head = seatNumber;
        seatDic[seatNumber]++;
    }
}

public class SeatManager2
{//采用题解方法：优先队列（其中实现方式有堆）或者堆
    PriorityQueue<int, int> queue;
    public SeatManager2(int n)
    {
        queue = new PriorityQueue<int, int>();
        for (int i = 1; i <= n; i++) queue.Enqueue(i, i);
    }

    public int Reserve()
    {
        return queue.Dequeue();
    }

    public void Unreserve(int seatNumber)
    {
        queue.Enqueue(seatNumber, seatNumber);
    }
}

/**
 * Your SeatManager object will be instantiated and called as such:
 * SeatManager obj = new SeatManager(n);
 * int param_1 = obj.Reserve();
 * obj.Unreserve(seatNumber);
 */

/**
 * Your SeatManager object will be instantiated and called as such:
 * SeatManager obj = new SeatManager(n);
 * int param_1 = obj.Reserve();
 * obj.Unreserve(seatNumber);
 */
/**
 * Your SeatManager object will be instantiated and called as such:
 * SeatManager obj = new SeatManager(n);
 * int param_1 = obj.Reserve();
 * obj.Unreserve(seatNumber);
 */