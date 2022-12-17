public class Solution1 {
    public int[] RunningSum(int[] nums) {
        //很简单，前缀和
        int []res=new int[nums.Length];
        res[0]=nums[0];
        for(int i=1;i<nums.Length;i++) res[i]=nums[i]+res[i-1];
        return res;

    }
}