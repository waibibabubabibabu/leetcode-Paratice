public class Solution
{
    public IList<IList<int>> PacificAtlantic(int[][] heights)//算法有问题，不能顾及到四周，不能用动态规划
    {
        //对每一个格子进行分析
        //想流入大西洋就向下和右流
        //想流入太平洋就向左和向上流
        IList<IList<int>> ans = new List<IList<int>>();

        //运用tag进行标记
        //tag=1，左上;tag=2，又下，tag=3，都可以
        int rowLen = heights.Length; int columnLen = heights[0].Length;
        int[][] tag = new int[rowLen][];
        for (int i = 0; i < rowLen; i++) tag[i] = new int[columnLen];
        //tag初始化
        //上侧f
        for (int i = 0; i < columnLen; i++) tag[0][i] += 1;
        //右侧
        for (int i = 0; i < rowLen-1; i++) tag[i][columnLen - 1] += 2;
        //下侧
        for (int i = 0; i < columnLen; i++) tag[rowLen - 1][i] += 2;
        //左侧
        for (int i = 1; i < rowLen; i++) tag[i][0] += 1;
        //修正
        //tag[0][0] = 1; tag[rowLen - 1][columnLen - 1] = 2;
        //为避免冲突，一次遍历进入一种大洋的方法：
        //左上的太平洋
        for (int i = 1; i < rowLen; i++)
        {
            for (int j = 1; j < columnLen; j++)
            {
                //不止要判断左上侧是否能流
                //左侧能否流？
                if (heights[i][j] >= heights[i][j - 1] && (tag[i][j - 1] == 1 || tag[i][j - 1] == 3)) tag[i][j] += 1;
                //上侧
                else if (heights[i][j] >= heights[i - 1][j] && (tag[i - 1][j] == 1 || tag[i - 1][j] == 3)) tag[i][j] += 1;
            }
        }
        //右下的大西洋，从右下角开始遍历
        for (int i = rowLen - 2; i >= 0; i--)
        {
            for (int j = columnLen - 2; j >= 0; j--)
            {
                //右侧能否流？
                if (heights[i][j] >= heights[i][j + 1] && (tag[i][j + 1] == 2 || tag[i][j + 1] == 3)) tag[i][j] += 2;
                //下侧
                else if (heights[i][j] >= heights[i + 1][j] && (tag[i + 1][j] == 2 || tag[i + 1][j] == 3)) tag[i][j] += 2;
            }
        }
        //遍历找3即可
        for (int i = 0; i < rowLen; i++)
            for (int j = 0; j < columnLen; j++)
                if (tag[i][j] == 3)
                {
                    IList<int>tmp=new List<int>();
                    tmp.Add(i);tmp.Add(j);
                    ans.Add(tmp);
                }
        return ans;
    }
}
public class Solutioncopy {
    static int[][] dirs = {new int[]{-1, 0}, new int[]{1, 0}, new int[]{0, -1}, new int[]{0, 1}};
    int[][] heights;
    int m, n;

    public IList<IList<int>> PacificAtlantic(int[][] heights) {
        this.heights = heights;
        this.m = heights.Length;
        this.n = heights[0].Length;
        bool[][] pacific = new bool[m][];
        bool[][] atlantic = new bool[m][];
        for (int i = 0; i < m; i++) {
            pacific[i] = new bool[n];
            atlantic[i] = new bool[n];
        }
        for (int i = 0; i < m; i++) {
            DFS(i, 0, pacific);
        }
        for (int j = 1; j < n; j++) {
            DFS(0, j, pacific);
        }
        for (int i = 0; i < m; i++) {
            DFS(i, n - 1, atlantic);
        }
        for (int j = 0; j < n - 1; j++) {
            DFS(m - 1, j, atlantic);
        }
        IList<IList<int>> result = new List<IList<int>>();
        for (int i = 0; i < m; i++) {
            for (int j = 0; j < n; j++) {
                if (pacific[i][j] && atlantic[i][j]) {
                    IList<int> cell = new List<int>();
                    cell.Add(i);
                    cell.Add(j);
                    result.Add(cell);
                }
            }
        }
        return result;
    }

    public void DFS(int row, int col, bool[][] ocean) {
        if (ocean[row][col]) {
            return;
        }
        ocean[row][col] = true;
        foreach (int[] dir in dirs) {
            int newRow = row + dir[0], newCol = col + dir[1];
            if (newRow >= 0 && newRow < m && newCol >= 0 && newCol < n && heights[newRow][newCol] >= heights[row][col]) {
                DFS(newRow, newCol, ocean);
            }
        }
    }
}
/*
作者：LeetCode-Solution
链接：https://leetcode.cn/problems/pacific-atlantic-water-flow/solution/tai-ping-yang-da-xi-yang-shui-liu-wen-ti-sjk3/
来源：力扣（LeetCode）
著作权归作者所有。商业转载请联系作者获得授权，非商业转载请注明出处。*/