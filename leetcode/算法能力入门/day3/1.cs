using System;
namespace LeeCode{
    class Solution1{
        
          public void Rotate(int[] nums, int k) {
            int temp;
            for(int i=0;i<k;i++)
            {
                temp=nums[i];
                for(int j=nums.Length-1;j>i;j--)
                {
                    nums[(j+1)%nums.Length]=nums[j];
                }
                nums[i+1]=temp;
            }
    }
    }
}