using System;
namespace LeeCode{
    class Solution1
    {
        public int SumOddLengthSubarrays(int[] arr) {
            int res=0;
            for(int len=1;len<=arr.Length;len+=2)
            {
                for(int i=0;i<arr.Length-len+1;i++)
                {
                    res+=arr.Skip(i).Take(len).Sum();
                }
               
                //res+=arr.Take(len).Sum();
            }
            return res;
    }
    public int SolutionA(int[] arr)
    {
        int res=0;
        int []preFixSum=new int[arr.Length+1];
        for(int i=0;i<preFixSum.Length-1;i++) preFixSum[i+1]=preFixSum[i]+arr[i];
        for(int len=1;len<=arr.Length;len+=2)
            {
                for(int i=0;i<=arr.Length-len;i++)
                {
                    res+=preFixSum[i+len]-preFixSum[i];
                }
               
                //res+=arr.Take(len).Sum();
            }
        return res;
    }
    }
}