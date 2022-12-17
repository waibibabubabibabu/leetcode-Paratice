public class Solution
{
    public int MaxProduct(int[] nums)
    {
        int maxF = nums[0], minF = nums[0], ans = nums[0];
        int length = nums.Length;
        for (int i = 1; i < length; ++i)
        {
            int mx = maxF, mn = minF;
            maxF = Math.Max(mx * nums[i], Math.Max(nums[i], mn * nums[i]));
            minF = Math.Min(mn * nums[i], Math.Min(nums[i], mx * nums[i]));
            ans = Math.Max(maxF, ans);
        }
        return ans;
    }
    /*
    作者：LeetCode-Solution
    链接：https://leetcode.cn/problems/maximum-product-subarray/solution/cheng-ji-zui-da-zi-shu-zu-by-leetcode-solution/
    来源：力扣（LeetCode）
    著作权归作者所有。商业转载请联系作者获得授权，非商业转载请注明出处。*/
    public int MaxProduct1(int[] nums)
    {
        // nums = [2,3,-2,4]
        int[][] dp = new int[nums.Length][];
        for (int i = 0; i < nums.Length; i++)
            dp[i] = new int[nums.Length];
        //init
        for (int i = 0; i < nums.Length; i++)
        {
            dp[i][i] = nums[i];
        }
        //传统dp超内存了
        int max = nums.Max();
        for (int i = 0; i < nums.Length; i++)
            for (int j = i + 1; j < nums.Length; j++)
            {
                dp[i][j] = dp[i][j - 1] * nums[j];
                max = Math.Max(max, dp[i][j]);
            }
        return max;
    }
}