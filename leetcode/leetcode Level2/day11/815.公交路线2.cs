public class Solution {
    public int NumBusesToDestination(int[][] routes, int source, int target) {
        if (source == target) {
            return 0;
        }

        int n = routes.Length;
        bool[,] edge = new bool[n, n];
        Dictionary<int, IList<int>> rec = new Dictionary<int, IList<int>>();
        for (int i = 0; i < n; i++) {
            foreach (int site in routes[i]) {
                IList<int> list = new List<int>();
                if (rec.ContainsKey(site)) {
                    list = rec[site];
                    foreach (int j in list) {
                        edge[i, j] = edge[j, i] = true;
                    }
                    rec[site].Add(i);
                } else {
                    list.Add(i);
                    rec.Add(site, list);
                }
            }
        }

        int[] dis = new int[n];
        Array.Fill(dis, -1);
        Queue<int> que = new Queue<int>();
        if (rec.ContainsKey(source)) {
            foreach (int bus in rec[source]) {
                dis[bus] = 1;
                que.Enqueue(bus);
            }
        }
        while (que.Count > 0) {
            int x = que.Dequeue();
            for (int y = 0; y < n; y++) {
                if (edge[x, y] && dis[y] == -1) {
                    dis[y] = dis[x] + 1;
                    que.Enqueue(y);
                }
            }
        }

        int ret = int.MaxValue;
        if (rec.ContainsKey(target)) {
            foreach (int bus in rec[target]) {
                if (dis[bus] != -1) {
                    ret = Math.Min(ret, dis[bus]);
                }
            }
        }
        return ret == int.MaxValue ? -1 : ret;
    }
}
/*
作者：LeetCode-Solution
链接：https://leetcode.cn/problems/bus-routes/solution/gong-jiao-lu-xian-by-leetcode-solution-yifz/
来源：力扣（LeetCode）
著作权归作者所有。商业转载请联系作者获得授权，非商业转载请注明出处。*/