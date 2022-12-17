using System;
namespace Leecode{
   public class Solution1 {
    public int SearchInsert(int[] nums, int target) {
        int begin=0;int end=nums.Length-1;
        int mid;//二分
        while(begin<=end)
        {
            mid=begin+(end-begin)/2;
            if(nums[mid]==target) return mid;
            if(nums[mid]>target) end=mid-1;
            else begin=mid+1;
        }
        //没找到
        return begin;
    }
}
}