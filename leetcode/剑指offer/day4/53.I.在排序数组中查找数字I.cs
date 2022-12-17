public class Solution2 {
    public int Search(int[] nums, int target) {
        //return Array.BinarySearch(nums,0,nums.Length,target);
        //统计出现的次数
        //不受搓的话
        int count=0;
        //int index=Array.BinarySearch(nums,0,nums.Length,target);
        if(nums.Length==0) return 0;
        int index=bianrySearch(nums,target);//尽量往左
        if(index<0) return 0;
        while(index<nums.Length&&nums[index]==target) {count++;index++;}
        return count;
    }
    public int bianrySearch(int[] nums,int target)
    {
        int left=0,right=nums.Length-1;
        int ans=left;
        while(left<=right)
        {
            int mid=(left+right)>>1;//向上取整
            if(nums[mid]>=target)
            {
                right=mid-1;
                ans=mid;
            }
            else left=mid+1;
        }
        return ans;
    }
}
public class Solutioncopy {
    public int Search(int[] nums, int target) {
        int leftIdx = BinarySearch(nums, target, true);
        int rightIdx = BinarySearch(nums, target, false) - 1;
        if (leftIdx <= rightIdx && rightIdx < nums.Length && nums[leftIdx] == target && nums[rightIdx] == target) {
            return rightIdx - leftIdx + 1;
        } 
        return 0;
    }

    public int BinarySearch(int[] nums, int target, bool lower) {
        int left = 0, right = nums.Length - 1, ans = nums.Length;
        while (left <= right) {
            int mid = (left + right) / 2;
            if (nums[mid] > target || (lower && nums[mid] >= target)) {
                right = mid - 1;
                ans = mid;
            } else {
                left = mid + 1;
            }
        }
        return ans;
    }
}
/*
作者：LeetCode-Solution
链接：https://leetcode.cn/problems/zai-pai-xu-shu-zu-zhong-cha-zhao-shu-zi-lcof/solution/zai-pai-xu-shu-zu-zhong-cha-zhao-shu-zi-wl6kr/
来源：力扣（LeetCode）
著作权归作者所有。商业转载请联系作者获得授权，非商业转载请注明出处。
*/