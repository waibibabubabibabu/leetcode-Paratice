public class Solution {
    public int[][] KClosest(int[][] points, int k) {//堆排序，多少个最小的数就用堆排序
        PriorityQueue<int[],int> pq=new PriorityQueue<int[], int>();
        foreach(int[] i in points) pq.Enqueue(i,i[1]*i[1]+i[0]*i[0]);
        int [][]res=new int[k][];
        for(int i=0;i<k;i++)
        {
            var a=pq.Dequeue();
            res[i]=new int[]{a[0],a[1]};
        }
        return res;
    }
}