using System;
namespace LeeCode{
    class Solution2
    {
         public void MoveZeroes(int[] nums) {
            int index=0;
            for(int i=0;i<nums.Length;i++)
            {
                if(nums[i]==0)
                {
                    index=i+1;
                    while(index<nums.Length&&nums[index]==0) index++;
                    if(index==nums.Length) break;
                    nums[i]=nums[index];
                    nums[index]=0;
                }
            }
    }
    }
}