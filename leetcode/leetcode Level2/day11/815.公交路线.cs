public class Map
{
    public int val;
    public int distance;
    public List<int> circle;
    public HashSet<Map> next;
    public HashSet<Map> before;
    public Map(int val, List<int> circle,HashSet<Map> next, HashSet<Map> before)
    {
        this.val = val;
        this.next = next;
        this.before = before;
        distance=int.MaxValue;
        this.circle=circle;
    }
}
public class Solution
{
    public int NumBusesToDestination(int[][] routes, int source, int target)
    {
        //DFS搜索
        Dictionary<int, Map> dic = new Dictionary<int, Map>();
        Queue<Map> cache;
        int icount=0;
        foreach (int[] i in routes)
        {
            cache = new Queue<Map>();
            for (int j = 0; j < i.Length; j++)
            {
                if (dic.ContainsKey(i[j]))
                {
                    cache.Enqueue(dic[i[j]]);
                }
                else
                {
                    Map tmp = new Map(i[j], new List<int>(),new HashSet<Map>(), new HashSet<Map>());
                    tmp.circle.Add(icount);
                    cache.Enqueue(tmp);
                    dic.Add(tmp.val, tmp);
                }
            }
            //把头部推入
            cache.Enqueue(dic[i[0]]);
            Map tmp1 = cache.Dequeue();
            tmp1.next.Add(cache.Peek());
            Map tmp2;
            while (cache.Count != 1)
            {
                tmp2 = cache.Dequeue();
                tmp2.next.Add(cache.Peek());
                tmp2.before.Add(tmp1);
                tmp1 = tmp2;
            }
        }
        if (!dic.ContainsKey(source) && dic.ContainsKey(target)) return -1;
        Map targetMap = dic[target];
        targetMap.distance = 0;
        DFSFindway(targetMap, source);//逆向思维，从到达点出发
        return dic[source].distance;
    }
    public Map DFSFindway(Map now, int target)
    {
        if (now.val == target) return now;
        foreach (Map i in now.before)
        {
            if (now.distance + 1 < i.distance)
            {
                i.distance = Math.Min(i.distance, now.distance + 1);
                DFSFindway(i, target);//有再次追踪的价值
            }
        }
        return now;
    }
}