using System;
class program{
    static void Main(string[]args)
    {
        /*int n=8;
        int headID=0;
        int []manager=new int[]{-1,5,0,6,7,0,0,0};
        int[] informtime=new int[]{89,0,0,0,0,523,241,519};
        Solution1 s1=new Solution1();
        int res=s1.NumOfMinutes(n,headID,manager,informtime);*/
        //
        string[] strs=new string[]{"eat", "tea", "tan", "ate", "nat", "bat"};
        string[] strs2=new string[]{"ddddddddddg","dgggggggggg"};
        Solution2 s2=new Solution2();
        s2.GroupAnagrams(strs);


    }
}