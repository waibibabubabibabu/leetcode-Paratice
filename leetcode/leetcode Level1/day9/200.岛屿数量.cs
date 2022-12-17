public class Solution
{
    //HashSet<HashSet<int[]>> islands;
    int count;
    public int NumIslands(char[][] grid)//官方题解的并查集没能理解
    {
        count = 0;
        //islands=new HashSet<HashSet<int[]>>();
        for (int i = 0; i < grid.Length; i++)
        {
            for (int j = 0; j < grid[0].Length; j++)
            {
                if (grid[i][j] == '1')
                {
                    findLand(i, j, grid);
                    count++;
                }
            }
        }
        return count;
    }
    public void findLand(int x, int y, char[][] grid)
    {
        grid[x][y] = '2';//表示已经遍历过
        if (x != 0 && grid[x - 1][y] == '1') findLand(x - 1, y, grid);
        if (x != grid.Length - 1 && grid[x + 1][y] == '1') findLand(x + 1, y, grid);
        if (y != 0 && grid[x][y - 1] == '1') findLand(x, y - 1, grid);
        if (y != grid[0].Length - 1 && grid[x][y + 1] == '1') findLand(x, y + 1, grid);
    }
}