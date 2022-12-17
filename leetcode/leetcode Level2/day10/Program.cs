class program{
    static void Main()
    {
        Solution s=new Solution();
        int[][]grid=new int[5][];
        grid[0]=new int[]{1,2,2,3,5};
        grid[1]=new int[]{3,2,3,4,4};
        grid[2]=new int[]{2,4,5,3,1};
        grid[3]=new int[]{6,7,1,4,5};
        grid[4]=new int[]{5,1,1,2,4};
        int[][]heights=new int[1][];
        heights[0]=new int[]{0};
        heights=new int[3][];
        heights[0]=new int[]{1,2,3};
        heights[1]=new int[]{8,9,4};
        heights[2]=new int[]{7,6,5};
        s.PacificAtlantic(heights);
    }
}