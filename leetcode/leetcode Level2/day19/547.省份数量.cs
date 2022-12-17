public class Solution1
{
    int count = 0;
    public int FindCircleNum(int[][] isConnected)
    {
        //能否修改原数组？
        //原矩阵应该是对称矩阵

        bool[] hasSearched = new bool[isConnected.Length];
        //for (int i = 0; i < isConnected.Length; i++) hasSearched[i] = new bool[isConnected.Length];
        //初始化bool数组，初值为FALSE
        for (int i = 0; i < isConnected.Length; i++)
        {
            //对每个城市进行dps
            Dps(isConnected, hasSearched, i);
        }
        /*
        for (int i = 0; i < isConnected.Length; i++)
            for (int j = i; j < isConnected.Length; j++)
            {
                if (isConnected[i][j]==1)//还没有被搜索过
                {
                    //插入函数，优先取消
                    if (!hasSearched[i][i])
                        count++;
                    hasSearched[j][j] = true;
                }
            }
            */
        return count;
    }
    public void Dps(int[][] isConnected, bool[] hasSearched, int row)
    {
        if (hasSearched[row] == false)
        {
            hasSearched[row] = true;//成立省份
            count++;
        }
        for (int i =0; i < isConnected.Length; i++)
        {
            if (i!=row&&isConnected[row][i] == 1&&!hasSearched[i])
            {
                hasSearched[i]=true;
                Dps(isConnected, hasSearched, i);
            }
        }
    }
}

class Solutioncopy {
    //并查集
    // Union Find
    // @爱学习的饲养员
    public int findCircleNum(int[][] isConnected) {
        if (isConnected == null || isConnected.Length == 0) {
            return 0;
        }

        int n = isConnected.Length;
        UnionFind uf = new UnionFind(n);
        for(int i = 0; i < n; i++) {
            for (int j = 0; j < n; j++) {
                if (isConnected[i][j] == 1) {
                    uf.union(i, j);
                }
            }
        }

        return uf.getCount();
    }

    public class UnionFind {
        int []root;
        int []rank;
        int count;

        public UnionFind(int size) {
            root = new int[size];
            rank = new int[size];
            count = size;
            for (int i = 0; i < size; i++) {
                root[i] = i;
                rank[i] = 1;
            }
        }

        int find(int x) {
            if (x == root[x]) {
                return x;
            }
            return root[x] = find(root[x]);
        }

        public void union(int x, int y) {
            int rootX = find(x);
            int rootY = find(y);
            if (rootX != rootY) {
                if (rank[rootX] > rank[rootY]) {
                    root[rootY] = rootX;
                } else if (rank[rootX] < rank[rootY]) {
                    root[rootX] = rootY;
                } else {
                    root[rootY] = rootX;
                    rank[rootX] += 1;
                }
                count--;
            }
        }

        public int getCount() {
            return count;
        }
    }
}
/*
作者：leetcode-learning
链接：https://leetcode.cn/problems/number-of-provinces/solution/li-kou-547-bing-cha-ji-si-lu-jiang-jie-b-u9qh/
来源：力扣（LeetCode）
著作权归作者所有。商业转载请联系作者获得授权，非商业转载请注明出处。*/