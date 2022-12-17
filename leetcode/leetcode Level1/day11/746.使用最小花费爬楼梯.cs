public class Solution1 {
    public int MinCostClimbingStairs(int[] cost) {//动态规划，使用数组保存原来的信息
        int []sumCost=new int[cost.Length+1];
        for(int i=2;i<cost.Length+1;i++)
            sumCost[i]=Math.Min(cost[i-1]+sumCost[i-1],cost[i-2]+sumCost[i-2]);
        return sumCost[cost.Length];
    }
    public int MinCostClimbingStairs1(int[]cost)//动态规划改进版，滑动窗口
    {
        int sumCost1=0,sumCost2=0;int sumCost=0;
        for(int i=2;i<cost.Length+1;i++){
            sumCost=Math.Min(cost[i-2]+sumCost1,cost[i-1]+sumCost2);
            sumCost1=sumCost2;sumCost2=sumCost;
        }
        return sumCost;
    }
}