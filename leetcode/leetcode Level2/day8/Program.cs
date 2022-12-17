class program{
    static void Main()
    {
        Solution s=new Solution();
        int[][]nums=new int[3][];
        nums[0]=new int[]{1,3,5,7};
        nums[1]=new int[]{10,11,16,20};
        nums[2]=new int[]{23,30,34,60};
        int target=10;
        int[][]nums1=new int[2][];
        nums1[0]=new int[]{1};
        nums1[1]=new int[]{3};
        target=3;
        s.SearchMatrix(nums1,target);
    }
}