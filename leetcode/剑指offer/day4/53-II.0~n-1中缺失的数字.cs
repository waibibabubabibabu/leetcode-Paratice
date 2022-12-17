public class Solution {
    public int MissingNumber(int[] nums) {
        //二分找
        //缩小条件是下标与数字不对应的第一个数字，返回其下标
        int left=0,right=nums.Length-1,ans=nums.Length;
        while(left<=right)
        {
            int mid=(right+left)>>1;
            if(nums[mid]>mid)
            {
                right=mid-1;
                ans=mid;
            }
            else left=mid+1;
        }
        return ans;
    }
}