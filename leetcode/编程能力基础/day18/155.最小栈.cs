public class MinStack
{//其余的是正常的栈操作，但是要得到最小值
    public Stack<int> stack;
    public PriorityQueue<int, int> queue;//常数时间内能找到吗？
                                         //public HashSet<int> hash;//用来查看queue中的元素是否存在
                                         //hash不能处理重复元素被推入栈
    public Dictionary<int, int> dictionary;
    public MinStack()
    {
        stack = new Stack<int>();
        queue = new PriorityQueue<int, int>();
        dictionary = new Dictionary<int, int>();
    }

    public void Push(int val)
    {
        stack.Push(val);
        //维护最小数输出
        queue.Enqueue(val, val);//数字本身也可以作为排序的序号
        if (dictionary.ContainsKey(val) == false) dictionary.Add(val, 1);
        else dictionary[val]++;
    }

    public void Pop()
    {
        int temp;
        temp = stack.Pop();
        //优先队列不好取出


    }

    public int Top()
    {
        return stack.Peek();
    }

    public int GetMin()
    {
        while (dictionary.ContainsKey(queue.Peek()) == false) queue.Dequeue();
        int temp = queue.Dequeue();
        if (dictionary[temp] == 0) dictionary.Remove(temp);
        else dictionary[temp]--;
        return temp;
    }
}

/**
 * Your MinStack object will be instantiated and called as such:
 * MinStack obj = new MinStack();
 * obj.Push(val);
 * obj.Pop();
 * int param_3 = obj.Top();
 * int param_4 = obj.GetMin();
 */

public class MinStack2
{
    //官方题解思路：利用栈的性质，在a以前被推入栈的元素均在栈内，不会变化，也就是可以在推入栈的同时递归维护栈推入后栈内的最小值是多少
    //可以用另一个栈对应栈的最小值
    Stack<int> stack;
    Stack<int> minStack;
    public MinStack2()
    {
        stack = new Stack<int>();
        minStack = new Stack<int>();

    }

    public void Push(int val)
    {
        stack.Push(val);
        if (minStack.Count == 0 || val < minStack.Peek()) minStack.Push(val);
        else minStack.Push(minStack.Peek());
    }

    public void Pop()
    {
        stack.Pop();
        minStack.Pop();
    }

    public int Top()
    {
        return stack.Peek();
    }

    public int GetMin()
    {
        return minStack.Peek();
    }
}

/**
 * Your MinStack object will be instantiated and called as such:
 * MinStack obj = new MinStack();
 * obj.Push(val);
 * obj.Pop();
 * int param_3 = obj.Top();
 * int param_4 = obj.GetMin();
 */

public class MinStack3
{//评论区有人说面试的时候不让用额外空间，看能不能实现
 //那就需要在存储本来的数值基础上，再存储大小关系
 //所以用min来确认当前栈的最小值，而压入栈的都是原本元素与min的差值

    Stack<long> stack;
    long min;//涉及加减，可能会溢出，用long
    public MinStack3()
    {
        stack=new Stack<long>();
    }

    public void Push(int val)
    {
        if(stack.Count==0)
        {
            min=val;
            stack.Push(0);//当前是最小值，减去最小值本身，就是0
            return ;
        }
        stack.Push((long)val-min);//如果大于，推入的是正数，如果小于，那么推入的是最小值
        min=Math.Min(min,val);//上一条的，更新最小值的方法
    }

    public void Pop()
    {
        long temp=stack.Pop();
        if(temp<0)//要把最小值退回上一个最小值
        {
            long nextmin=min;
            min=nextmin-temp;//退回上一个最小值
        }
    }

    public int Top()
    { 
        long res=stack.Peek();
        if(res<=0) return (int)min;
        else return (int)(res+min); 
    }

    public int GetMin()
    {
        return (int)min;
    }
}

/**
 * Your MinStack object will be instantiated and called as such:
 * MinStack obj = new MinStack();
 * obj.Push(val);
 * obj.Pop();
 * int param_3 = obj.Top();
 * int param_4 = obj.GetMin();
 */