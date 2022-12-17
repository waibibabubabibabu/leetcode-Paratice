class program{
    static void Main()
    {
        Solution s=new Solution();
       int [][]stones=new int[6][];
       stones[0]=new int[]{0,0};
       stones[1]=new int[]{0,1};
       stones[2]=new int[]{1,0};
       stones[3]=new int[]{1,2};
       stones[4]=new int[]{2,1};
       stones[5]=new int[]{2,2};
       s.RemoveStones(stones);
    }
}