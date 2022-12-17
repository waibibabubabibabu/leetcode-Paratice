using System;
namespace Leecode{
    class Solution1{
        public int LargestPerimeter(int[] nums) {
            Bubble(nums);
            int index=nums.Length-1;
            int MaxPermeter=0;
            while(index>1) 
            {
                MaxPermeter=Judge(nums,MaxPermeter,index);
                index--;
            }
            return MaxPermeter;
    }
    public void Bubble(int[] nums)
    {
        for(int i=0;i<nums.Length;i++)
        {
            for(int j=nums.Length-1;j>i;j--)
            {
                if(nums[j]<nums[j-1])
                {
                    int temp=nums[j];
                    nums[j]=nums[j-1];
                    nums[j-1]=temp;
                }
            }
        }
    }
    public int Judge(int[] nums,int MaxPermeter,int index)
    {
        int Permeter=0;
        if(nums[index-2]+nums[index-1]>nums[index]) Permeter=nums[index-2]+nums[index-1]+nums[index];
        return Math.Max(Permeter,MaxPermeter);
    }
    }
}