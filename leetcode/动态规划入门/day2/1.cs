using System;
namespace Leecode{
    class Solution1{
        public int ClimbStairs(int n) {
            if(n==1) return 1;
            if(n==2) return 2;
            if(n>2) return ClimbStairs(n-1)+ClimbStairs(n-2);
            return -1;
    }
    }
    class Solution1Dot1
    {
        public int ClimbStairs(int n)
        {
            int []list=new int[n];
            if(n==1)return 1;
            list[0]=1;list[1]=2;
            for(int i=2;i<n;i++)list [i]=list[i-1]+list[i-2];
            return list[n-1];
        }
    }
    
}