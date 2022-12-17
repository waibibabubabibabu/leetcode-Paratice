public class Solution1
{
    public int OrangesRotting(int[][] grid)
    {
        //如何设计数据结构
        //腐烂一次的橘子不会再腐烂第二次
        Queue<int[]> queueRotted = new Queue<int[]>();
        int freshCount = 0;
        for (int i = 0; i < grid.Length; i++)
        {
            for (int j = 0; j < grid[0].Length; j++)
            {
                if (grid[i][j] == 1) freshCount++;
                else if (grid[i][j] == 2)
                    queueRotted.Enqueue(new int[] { i, j });
            }
        }
        int time = 0;
        while (freshCount > 0)//开始腐蚀
        {
            int rottedCount = queueRotted.Count;//本轮要腐蚀周边的橘子个数
            int rottingCount = 0;//本轮被新腐蚀的橘子个数
            while (rottedCount > 0)
            {
                int[] tmp = queueRotted.Dequeue();
                rottedCount--;
                int tmpx = tmp[0], tmpy = tmp[1];
                //上侧
                if (tmpx > 0 && grid[tmpx - 1][tmpy] == 1) { rottingCount++; freshCount--; grid[tmpx - 1][tmpy] = 2; queueRotted.Enqueue(new int[] { tmpx - 1, tmpy }); }
                //下侧
                if (tmpx < grid.Length - 1 && grid[tmpx + 1][tmpy] == 1) { rottingCount++; freshCount--; grid[tmpx + 1][tmpy] = 2; queueRotted.Enqueue(new int[] { tmpx + 1, tmpy }); }
                //左侧
                if (tmpy > 0 && grid[tmpx][tmpy - 1] == 1) { rottingCount++; freshCount--; grid[tmpx][tmpy - 1] = 2; queueRotted.Enqueue(new int[] { tmpx, tmpy - 1 }); }
                //右侧
                if (tmpy < grid[0].Length - 1 && grid[tmpx][tmpy + 1] == 1) { rottingCount++; freshCount--; grid[tmpx][tmpy + 1] = 2; queueRotted.Enqueue(new int[] { tmpx, tmpy + 1 }); }
            }
            if (rottingCount == 0 && freshCount > 0) return -1;
            time++;
        }
        return time;
    }
}