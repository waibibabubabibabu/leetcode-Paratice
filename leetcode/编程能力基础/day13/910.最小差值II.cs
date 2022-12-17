public class Solution1
{
    public int SmallestRangeII(int[] nums, int k)
    {
        //先遍历：
        /*if (nums.Length <= 1) return 0;
        int min = nums[0], max = nums[0];//初始化，是处理前的,但是还未处理nums【0】
        int minIndex = 0, maxIndex = 0;
        int afterMinIndex = 0;
        for (int i = 1; i < nums.Length; i++)
        {
            if (nums[i] - k < min)//有成为最小数的资格
            {
                if (nums[i] > min)//是不是要真正成为最小数
                {
                    nums[i] -= k;
                    afterMinIndex = i;
                }
                min = nums[i];
                minIndex = i;
            }

        }
        if (minIndex == 0) {min = nums[0] - k;afterMinIndex=0;}

        return min;*/
        //根据提示，用排序和贪心
        Array.Sort(nums);
        int len=nums.Length;
        int res=nums[len-1]-nums[0];
        //int min=nums[0],max=nums[len-1];
        for(int i=0;i<len-1;i++)
        {
            int min=Math.Min(nums[0]+k,nums[i+1]-k);//找到第一个就行，因为是有序的
            int max=Math.Max(nums[len-1]-k,nums[i]+k);//实际只变化一次，因为是有序的
            res=Math.Min(res,max-min);
        }
        return res;
    }
}