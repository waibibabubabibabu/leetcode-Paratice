public class CQueue
{
    Stack<int> inQueue;
    Stack<int> outQueue;

    public CQueue()
    {
        inQueue = new Stack<int>();
        outQueue = new Stack<int>();
    }

    public void AppendTail(int value)
    {
        inQueue.Push(value);
    }

    public int DeleteHead()
    {
        if(outQueue.Count==0)
        {
            if(inQueue.Count==0) return -1;
            else{
                //对inqueue的元素进行转移
                while(inQueue.Count>0) outQueue.Push(inQueue.Pop());
            }
        }
        return outQueue.Pop();
    }
}

/**
 * Your CQueue object will be instantiated and called as such:
 * CQueue obj = new CQueue();
 * obj.AppendTail(value);
 * int param_2 = obj.DeleteHead();
 */