public class Solution1
{
    public int MaxProfit(int[] prices)//动态规划其实可以优化
    {
        //从后向前构造max值
        if (prices.Length == 0) return 0;
        int len = prices.Length;
        int max=0;int maxProfit = 0;
        for (int i = len - 1; i >= 0; i--)
        {
            if (prices[i] > max) max = prices[i];
            if(max-prices[i]>maxProfit)  maxProfit = max - prices[i];
        }
        return maxProfit;
    }
}