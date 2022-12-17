public class Solution
{
    public int MinArray(int[] numbers)
    {
        //二分，查找第一个降序的
        
        int left = 0, right = numbers.Length - 1;
        //int ans = Search(numbers, left, right);
        while(left<right)
        {
            int mid=(left+right)/2;
            if(numbers[mid]<numbers[right]) right=mid;
            else if(numbers[mid]>numbers[right]) left=mid+1;
            else right-=1;
        }
        return numbers[left];
        

    }
    public int Search(int[] nums, int left, int right)
    {
        if (left == right) return nums[left];
        int mid = (left + right) / 2;
        if (nums[left] >= nums[right])
        {
            if (nums[mid] > nums[right]) return Search(nums, mid + 1, right);
            else if(nums[mid]<nums[right]) return Search(nums, left, mid);
            else {
                //相等的条件不能武断，可能是在最小值的左侧，也可能是在右侧
                // 由于它们的值相同，所以无论 \textit{numbers}[\textit{high}]numbers[high] 是不是最小值，都有一个它的「替代品」
                // \textit{numbers}[\textit{pivot}]numbers[pivot]，因此我们可以忽略二分查找区间的右端点。
                return Search(nums,left,right-1);
            }
        }
        else return nums[left];
    }
}