public class Solution1
{
    public int[] TwoSum(int[] nums, int target)
    {
        int []res=new int[]{};
        for (int i = 0; i < nums.Length; i++)
            for (int j = i + 1; j < nums.Length; j++)//向后寻找的时候用hash表，target-x可以降低一些时间复杂度
                if (nums[i] + nums[j] == target) return new int[] { i, j };
        return res;
    }
}