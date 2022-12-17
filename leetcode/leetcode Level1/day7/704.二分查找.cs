public class Solution1 {
    public int Search(int[] nums, int target) {
        int left=0,right=nums.Length-1;
        int mid;
        while(left<right)
        {
            mid=(right-left)/2+left;
            if(target==nums[mid]) return mid;
            else if(nums[mid]>target) right=mid-1;
            else left=mid+1;
        }
        return -1;
    }
}