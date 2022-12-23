

public class Solution {
    public int MaxValue(int[][] grid) {
        //格子可以从左边来，也可以从上边来
        //初始化左边界和上边界，求最大值
        int [][]sum=new int[grid.Length][];
        for(int i=0;i<grid.Length;i++) sum[i]=new int[grid[0].Length];
        //初始化左上边界
        sum[0][0]=grid[0][0];
        for(int i=1;i<sum.Length;i++) sum[i][0]=grid[i][0]+sum[i-1][0];
        for(int j=1;j<sum[0].Length;j++) sum[0][j]=grid[0][j]+sum[0][j-1];
        //求更大的值
        for(int i=1;i<sum.Length;i++)
        {
            for(int j=1;j<sum[0].Length;j++)
            {
                //因为每次只涉及上一行，可以循环利用一行，即
                // dp[j] = Math.max(dp[j], dp[j - 1]) + grid[i - 1][j - 1];
                sum[i][j]=Math.Max(sum[i-1][j],sum[i][j-1])+grid[i][j];
            }
        }
        return sum[sum.Length-1][sum[0].Length-1];
    }
}