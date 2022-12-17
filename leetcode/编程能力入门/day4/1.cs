using System;
namespace Leecode{
    class Solution1{
          public int ArraySign(int[] nums) {
            int sign=1;
            for(int i=0;i<nums.Length;i++)
            {
                if(nums[i]==0) sign=0;
                if(nums[i]<0) sign*=-1;
            }
            return sign;
            
    }
    }
}