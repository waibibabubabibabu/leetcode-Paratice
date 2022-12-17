class program{
    static void Main()
    {
        Solution s=new Solution();
        int[][]intervals=new int[5][];
        intervals[0]=new int[]{1,2};
        intervals[1]=new int[]{3,5};
        intervals[2]=new int[]{6,7};
        intervals[3]=new int[]{8,10};
        intervals[4]=new int[]{12,16};
        int[]newInterval=new int[]{4,8};
        s.Insert(intervals,newInterval);
    }
}