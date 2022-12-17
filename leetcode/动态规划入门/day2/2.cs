using System;
namespace Leecode{
    class Solution2{
        public int MinCostClimbingStairs(int[] cost) {
            int len=cost.Length;
            int []sum=new int[len];
            //int []sum=cost.Take(2).ToArray();
            //Array.Copy(cost,sum,2);
            //sum[0]=sum[1]=Math.Min(cost[0],cost[1]);
            for(int i=2;i<sum.Length;i++)
            {
                sum[i]=Math.Min(cost[i-1]+sum[i-1],cost[i-2]+sum[i-2]);
            }
            return Math.Min(sum[len-1]+cost[len-1],sum[len-2]+cost[len-2]);
        }
    
    }
}
