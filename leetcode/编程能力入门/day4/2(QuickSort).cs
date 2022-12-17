using System;
namespace Leecode{
    class Solution2{
         public bool CanMakeArithmeticProgression(int[] arr) {
            QuickSort(arr,0,arr.Length-1);
            int div=arr[1]-arr[0],i=2;
            while(i<arr.Length) 
            {
                if(arr[i]-arr[i-1]!=div)return false;
                i++;
            }
            return true;
    }
    public void QuickSort(int[] nums,int left,int right)
    {
        if(left<right)
        {
            int i=left,j=right;int key=nums[left];
            while(i<j)
            {
                while(nums[i]<=key&&i<right) i++;
                while(nums[j]>=key&&j>left) j--;
                if(i>j) break;
                Swap(nums,i,j);
            }
            nums[left]=nums[j];
            nums[j]=key;
            QuickSort(nums,left,j-1);
            QuickSort(nums,j+1,right);
        }
    }
    void Swap(int []nums,int i,int j)
    {
        int temp=nums[i];
        nums[i]=nums[j];
        nums[j]=temp;
    }
    }
}