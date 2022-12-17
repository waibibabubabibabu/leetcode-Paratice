public class Solution
{
    public int PivotIndex(int[] nums)
    {
        if (nums.Length == 1) return 0;
        int sum = nums.Sum();
        int index = 0;
        int sumLeft = 0;
        while (index<nums.Length&&(float)sumLeft != (float)(sum - nums[index]) / 2) sumLeft += nums[index++];
        if(index==nums.Length) return -1;//表示没找到
        else return index;
    }
    public int PivotIndex2(int[] nums)//前缀和太占空间了
    {
        int[] sumPrefix = new int[nums.Length + 2];
        for (int i = 1; i <= nums.Length; i++) sumPrefix[i] = sumPrefix[i - 1] + nums[i - 1];//首位两位置零
        int sum = sumPrefix[nums.Length];
        for (int i = 0; i < nums.Length; i++)
        {
            if ((float)sumPrefix[i] == (float)(sum - (sumPrefix[i + 1] - sumPrefix[i])) / 2)
                return i;

        }
        return -1;
    }
}