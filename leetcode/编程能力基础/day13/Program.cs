class program{
    static void Main(string[]args)
    {
        /*int [][]mat2=new int[1][];
        mat2[0]=new int[]{-4,-5};

        int[][]mat=new int[5][];
        mat[0]=new int[]{3,0,1,4,2};
        mat[1]=new int[]{5,6,3,2,1};
        mat[2]=new int[]{1,2,0,1,5};
        mat[3]=new int[]{4,1,0,1,7};
        mat[4]=new int[]{1,0,3,0,5};
        NumMatrix n1=new NumMatrix(mat2);
        n1.SumRegion(2,1,4,3);*/
        Solution1 s1=new Solution1();
        int []nums=new int[]{0,-1,6,1 ,3, 5};
        int k=3;
        s1.SmallestRangeII(nums,k);

    }
}