public class Solution {
    public bool IsMonotonic(int[] nums) {
        if(nums.Length<=2) return true;
        int d=0;
        for(int i=1;i<nums.Length-1;i++)
        {
            if(nums[i].CompareTo(nums[i+1])!=0) d=nums[i].CompareTo(nums[i+1]);
           if(nums[i].CompareTo(nums[i+1])*d==-1) return false;
        }
        return true;
    }
}