public class Solution
{
    public int CoinChange(int[] coins, int amount)
    {
        if (amount < 1) {
            return 0;
        }
        return coinChange(coins, amount, new int[amount]);
    }

    private int coinChange(int[] coins, int rem, int[] count) {
        if (rem < 0) {
            return -1;
        }
        if (rem == 0) {
            return 0;
        }
        if (count[rem - 1] != 0) {
            return count[rem - 1];
        }
        int min = int.MaxValue;
        foreach (int coin in coins) {
            int res = coinChange(coins, rem - coin, count);
            if (res >= 0 && res < min) {
                min = 1 + res;
            }
        }
        count[rem - 1] = (min == int.MaxValue) ? -1 : min;
        return count[rem - 1];
    }
    public int min = int.MaxValue;
    public int CoinChange1(int[] coins, int amount)
    {
        int[] FS=new int[amount];
        //bfs(coins, amount, 0,FS);
        /*Queue<int[]> queue = new Queue<int[]>();
        queue.Enqueue(new int[] { amount, 0 });//模拟递归，用队列暂存结果.结果队列超长了
        while (queue.Count > 0)
        {
            int[] tmp = queue.Dequeue();
            if (tmp[0] == 0) min = Math.Min(tmp[1], min);
            else if (tmp[0] > 0)
                foreach (int i in coins) queue.Enqueue(new int[] { tmp[0] - i, tmp[1] + 1 });
        }
        */
        if (min == int.MaxValue) return -1;
        else return min;

    }
    public void bfs(int[] coins, int amount, int count,int[] FS)
    {
        if (amount == 0)
            min = Math.Min(min, count);
        if (amount < 0) return;
        foreach (int i in coins) bfs(coins, amount - i, count + 1);
    }
}
