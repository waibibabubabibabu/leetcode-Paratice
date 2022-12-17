public class MinStack
{//评论区有人说面试的时候不让用额外空间，看能不能实现
 //那就需要在存储本来的数值基础上，再存储大小关系
 //所以用min来确认当前栈的最小值，而压入栈的都是原本元素与min的差值

    Stack<long> stack;
    long min;//涉及加减，可能会溢出，用long
    public MinStack()
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