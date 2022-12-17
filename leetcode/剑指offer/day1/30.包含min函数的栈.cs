public class MinStack
{

    /** initialize your data structure here. */
    Stack<int> valueStack;//存入的是value与min的差值
    Stack<int> min;
    public MinStack()
    {
        valueStack = new Stack<int>();
        min = new Stack<int>();
    }

    public void Push(int x)
    {
        valueStack.Push(x);
        if(min.Count==0) min.Push(x);
        else min.Push(Math.Min(x,min.Peek()));
    }

    public void Pop()
    {
        if (valueStack.Count == 0) return;
        valueStack.Pop();
        min.Pop();
    }

    public int Top()
    {
        return valueStack.Peek();
    }

    public int Min()
    {
        if(min.Count==0) return 0;
        return min.Peek();
    }
}

/**
 * Your MinStack object will be instantiated and called as such:
 * MinStack obj = new MinStack();
 * obj.Push(x);
 * obj.Pop();
 * int param_3 = obj.Top();
 * int param_4 = obj.Min();
 */