using System;
class prgram{
    static void Main(string[]args)
    {
        /*string s="abab",p = "ab";
        Solution1 s1=new Solution1();
        s1.FindAnagrams2(s,p);*/
        Solution2 s2=new Solution2();
        int []nums=new int[]{10,5,2,6};
        int k=100;
        s2.NumSubarrayProductLessThanK(nums,k);

    }
}