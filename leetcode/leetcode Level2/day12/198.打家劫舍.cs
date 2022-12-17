public class Solution1 {
    public int Rob(int[] nums) {
        //动态规划
        int []dp=new int[nums.Length];
        //for(int i=0;i<nums.Length;i++) dp[i]=new int[nums.Length];
        //初始化：
        if(nums.Length==1) return nums[0];
        dp[0]=nums[0];
        dp[1]=Math.Max(nums[0],nums[1]);
        for(int i=2;i<nums.Length;i++)
        {
            dp[i]=Math.Max(dp[i-1],dp[i-2]+nums[i]);//今晚偷或者不偷
        }
        return dp[nums.Length-1];
    }
}