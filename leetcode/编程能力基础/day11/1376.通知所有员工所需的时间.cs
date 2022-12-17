public class Solution1 {
    public int NumOfMinutes(int n, int headID, int[] manager, int[] informTime) {//题目变形，n叉树找耗时最大的通路
    //方法超时，可能是没有运用n
    //查看题解后，发现自己的时间复杂度是n^n，没有用数据结构

    int maxTime=0;//经理本身
    for(int i=0;i<n;i++)
    {
        if(manager[i]==headID) maxTime=Math.Max(maxTime,NumOfMinutes(n,i,manager,informTime));
        //if(manager[i]==headID) currres+=NumOfMinutes(n,i,manager,informTime);//同时传递，是加最大值
        //是下属
    }
    return maxTime+informTime[headID];
    }
}
    public class Solution1Copy {
    public int NumOfMinutes(int n, int headID, int[] manager, int[] informTime) {
        //花O（n）时间构造树木
        IList<int>[] subordinatesArr = new IList<int>[n];
        for (int i = 0; i < n; i++) {
            subordinatesArr[i] = new List<int>();
        }
        for (int i = 0; i < n; i++) {
            if (i != headID) {
                subordinatesArr[manager[i]].Add(i);//可以通过manager查i，不用想我上面一样再次遍历了，节约了时间
            }
        }
        //花n时间遍历
        int maxTime = 0;
        Queue<Tuple<int, int>> queue = new Queue<Tuple<int, int>>();
        queue.Enqueue(new Tuple<int, int>(headID, 0));
        while (queue.Count > 0) {
            Tuple<int, int> employee = queue.Dequeue();
            int id = employee.Item1, time = employee.Item2;
            maxTime = Math.Max(maxTime, time);
            IList<int> subordinates = subordinatesArr[id];//取树结构
            int nextTime = time + informTime[id];
            foreach (int subordinate in subordinates) {
                queue.Enqueue(new Tuple<int, int>(subordinate, nextTime));//将该节点的孩子全部推入
            }
        }
        return maxTime;
    }
}
