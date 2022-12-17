using System;
namespace Leecode{
    class Solution1{
        public int Search(int[] nums, int target) {
            int begin=0,end=nums.Length-1;
            while(true)
            {
                int mid=(end+begin)/2;
                if(target==nums[mid]) return mid;
                else{
                    if(target>nums[mid]) begin=mid;
                    else end=mid;
                }
                if(end-begin<=1)
                {
                    if(nums[end]==target) return end;
                    if(nums[begin]==target) return begin;
                    return -1;
                }
            }
    }
    }
}