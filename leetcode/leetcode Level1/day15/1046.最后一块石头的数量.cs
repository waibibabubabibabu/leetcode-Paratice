public class Solution1 {
    public int LastStoneWeight(int[] stones) {
        PriorityQueue<int,int> heap=new PriorityQueue<int, int>();
        for(int i=0;i<stones.Length;i++) heap.Enqueue(stones[i],-stones[i]);
        int ans=0;
        int x,y;
        while(heap.Count>1)
        {
            x=heap.Dequeue();
            y=heap.Dequeue();
            if(x<y) heap.Enqueue(y-x,x-y);
            else if(x>y) heap.Enqueue(x-y,y-x);
        }
        if(heap.Count==1) ans=heap.Dequeue();
        return ans;
    }
}