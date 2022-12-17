public class Solution1
{
    public bool CanPartition(int[] nums)
    {
        int target = nums.Sum();
        if (target % 2 != 0) return false;
        target /= 2;
        //老老实实动态规划
        bool[] numsBool = new bool[target + 1];
        numsBool[0] = true;
        bool[] flag;
        foreach (int i in nums)
        {
            flag = new bool[target + 1];
            if (numsBool[target]) return true;
            if (i <= target)
            {
                if (!numsBool[i])
                {
                    numsBool[i] = true;
                    flag[i] = true;
                }
                for (int j = 1; j < numsBool.Length; j++)
                {
                    if (j + i <= target && numsBool[j] &&!numsBool[j+i]&& !flag[j])
                    {
                        numsBool[i + j] = true;
                        flag[j] = true;
                        flag[j + i] = true;
                    }
                }
            }
        }
        return false;
    }
}