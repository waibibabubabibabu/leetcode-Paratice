public class Solution
{
    public int MaxProfit(int[] prices)//最佳解法
    {
        //维护最小值？
        //维护递增栈，将栈中大于目前值的删去
        //Stack<int> stack = new Stack<int>();
        int max = 0;
        int min = int.MaxValue;
        foreach (int i in prices)
        {
            min=Math.Min(i,min);
            max=Math.Max(max,i-min);
        }
        return max;
    }
     public int MaxProfit1(int[] prices)
    {
        //维护最小值？
        //维护递增栈，将栈中大于目前值的删去
        Stack<int> stack = new Stack<int>();
        int max = 0;
        int min = int.MaxValue;
        foreach (int i in prices)
        {
            while (stack.Count > 0 && i < stack.Peek()) stack.Pop();
            stack.Push(i);
            if (stack.Count == 1) min = i;
            if (stack.Count > 0) max = Math.Max(max, stack.Peek() - min);
        }
        return max;
    }
    public int MaxProfit2(int[] prices)
    {
        int max = 0;
        int[][] profit = new int[prices.Length][];
        //暴力解法会超出大小范围
        for (int i = 0; i < prices.Length; i++) profit[i] = new int[prices.Length];
        for (int i = 0; i < prices.Length; i++)
        {
            for (int j = i + 1; j < prices.Length; j++)
            {
                profit[i][j] = prices[j] - prices[i];
                max = Math.Max(profit[i][j], max);
            }
        }
        return max;
    }
}