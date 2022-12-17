class program{
    static void Main()
    {
        Solution s=new Solution();
        int [][]matrix=new int[5][];
        matrix[0]=new int[]{1,   4,  7, 11, 15};
        matrix[1]=new int[]{2,   5,  8, 12, 19};
        matrix[2]=new int[]{3,   6,  9, 16, 22};
        matrix[3]=new int[]{10, 13, 14, 17, 24};
        matrix[4]=new int[]{18, 21, 23, 26, 30};
        matrix=new int[1][];
        matrix[0]=new int[]{-1,3};
        
        int []numbers=new int[]{3,3,1,3};
        s.MinArray(numbers);
    }
}