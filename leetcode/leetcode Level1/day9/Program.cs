class program
{
    static void Main(string[] args)
    {
        Solution s = new Solution();
        /*int sr = 0;
        int sc = 0;
        int color = 0;
        int[][] image = new int[2][];
        image[0] = new int[3] { 0,0,0 };
        image[1] = new int[3] { 0,0,0 };
        //image[2] = new int[3] { 0,0,0 };
        s.FloodFill(image,sr,sc,color);*/
        char[][] grid = new char[4][];
        grid[0] = new char[5] {'1','1','1','1','0' };
        grid[1] = new char[5] { '1','1','0','1','0'};
        grid[2] = new char[5] {'1','1','0','0','0' };
        grid[3] = new char[5] {'0','0','0','0','0' };

        s.NumIslands(grid);
    }
}