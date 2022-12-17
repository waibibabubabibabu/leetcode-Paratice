using System;
public class MyQueue {
    Stack<int> stackIn;
    Stack<int> stackOut;
    public MyQueue() {
        stackIn=new Stack<int>();
        stackOut=new Stack<int>();
    }
    
    public void Push(int x) {
        stackIn.Push(x);
    }
    public void transform()
    {
        if(Empty()==true) return ;
        if(stackOut.Count==0&&stackIn.Count!=0)
        {
            while(stackIn.Count!=0) stackOut.Push(stackIn.Pop());
        }
    }
    public int Pop() {
        if(Empty()==true) return -1;
        if(stackOut.Count!=0) return stackOut.Pop();
        else 
        { transform();return Pop();}
        return -1;
    }
    
    public int Peek() {
        if(Empty()==true) return -1;
        if(stackOut.Count!=0) return stackOut.Peek();
        else
        { transform();return Peek();}
        return -1;

    }
    
    public bool Empty() {
        if(stackIn.Count==0&&stackOut.Count==0) return true;
        else return false;
    }
}

/**
 * Your MyQueue object will be instantiated and called as such:
 * MyQueue obj = new MyQueue();
 * obj.Push(x);
 * int param_2 = obj.Pop();
 * int param_3 = obj.Peek();
 * bool param_4 = obj.Empty();
 */