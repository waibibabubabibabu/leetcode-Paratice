public class Solution
{
    public int UniquePaths(int m, int n)
    {
        //递归肯定又溢出
        //直接动态规划
        int[,] path = new int[m, n];
        //先初始化
        for (int i = 0; i < n; i++) path[0, i] = 1;
        for (int i = 0; i < m; i++) path[i, 0] = 1;
        //左上累加
        for (int i = 1; i < m; i++)
            for (int j = 1; j < n; j++)
                path[i, j] = path[i - 1, j] + path[i, j - 1];
        return path[m - 1, n - 1];
    }
    public int UniquePaths1(int m, int n)//dp优化，减少空间复杂度
    {
        //只需要记录上面一行的数据和左边的数据
        //并且可以交换m，n，使得新建的一维数组是最小值
        if (m < n)
        {
            int temp = m;
            m = n;
            n = temp;
        }
        int[] path = new int[n];
        for (int i = 0; i < n; i++)
            path[i] = 1;
        //初始化为1
        int row;//行数记录
        int behind = 1;//初始化为1
        for (row = 1; row < m; row++)
        {
            for (int i = 1; i < n; i++)
            {
                path[i]+=behind;//当前行和上一行混用，直接在原数组上更改
                behind=path[i];
            }
            behind=1;
        }
        return path[n-1];
    }

}