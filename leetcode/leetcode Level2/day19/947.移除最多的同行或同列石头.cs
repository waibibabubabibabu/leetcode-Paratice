public class Solution
{
    public int RemoveStones(int[][] stones)
    {
        //并查集，stone的count
        UnionFind un = new UnionFind(stones.Length);

        for (int i = 0; i < stones.Length - 1; i++)
        {
            for(int j=i+1;j<stones.Length;j++)
            {
                if (stones[i][0] == stones[j][0] || stones[i][1] == stones[j][1])
                un.union(i, j);
            }
            
        }
        return stones.Length-un.getCount();
    }
    class UnionFind
    {
        int[] root;
        int[] rank;
        int count;

        public UnionFind(int size)
        {
            root = new int[size];
            rank=new int[size];
            count = size;
            for (int i = 0; i < size; i++)
            {
                root[i] = i;
                rank[i] = 1;
            }
        }

        int find(int x)
        {
            if (x == root[x])
            {
                return x;
            }
            return root[x] = find(root[x]);
        }

        public void union(int x, int y)
        {
            int rootX = find(x);
            int rootY = find(y);
            if (rootX != rootY)
            {
                if (rank[rootX] > rank[rootY])
                {
                    root[rootY] = rootX;
                }
                else if (rank[rootX] < rank[rootY])
                {
                    root[rootX] = rootY;
                }
                else
                {
                    root[rootY] = rootX;
                    rank[rootX] += 1;
                }
                count--;
            }
        }

        public int getCount()
        {
            return count;
        }
    }
}
