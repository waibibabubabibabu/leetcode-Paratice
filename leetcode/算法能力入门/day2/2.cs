using System;
namespace Leecode{
public class Solution2 {
    public int[] SortedSquares(int[] nums) {
        for(int i=0;i<nums.Length;i++) nums[i]*=nums[i];
        int []numsT=new int[nums.Length];
        int left=0,right=nums.Length-1;int index=right;
        while(left<=right)
        {
            if(nums[right]>nums[left]){numsT[index]=nums[right];right--;}
            else{numsT[index]=nums[left];left++;}
            index--;
        }
       return numsT;
    }
}

}