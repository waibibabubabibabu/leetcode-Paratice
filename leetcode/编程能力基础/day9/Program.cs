using System;
class program{
    static void Main(string[]args)
    {
        Solution1 s1=new Solution1();
        int []nums=new int[]{4,6,5,9,3,7};
        int []l=new int[]{0,0,2};
        int []r=new int[]{2,3,5};
        s1.CheckArithmeticSubarrays(nums,l,r);
    }
}