public class Solution2
{
    public int NumSubarrayProductLessThanK(int[] nums, int k)
    {
        //滑动窗口
       int n = nums.Length, ret = 0;
        int prod = 1, i = 0;
        for (int j = 0; j < n; j++) {
            prod *= nums[j];
            while (i <= j && prod >= k) {
                prod /= nums[i];
                i++;
            }
            ret += j - i + 1;//满足一个存一个，就不用看是否计算过了
        }
        return ret;
    }
}