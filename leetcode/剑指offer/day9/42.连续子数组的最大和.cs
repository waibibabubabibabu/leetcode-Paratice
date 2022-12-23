

public class Solution1
{
    //滑动窗口？
    //dp原理是，如果ij是最大连续子数组的最大和，那么ij-1也一定是前半段的最大连续子数组和
    public int MaxSubArray(int[] nums)
    {
        int pre = 0, maxAns = nums[0];
        foreach (int x in nums)
        {
            pre = Math.Max(pre + x, x);
            maxAns = Math.Max(maxAns, pre);
        }
        return maxAns;
    }
}
/*
作者：LeetCode-Solution
链接：https://leetcode.cn/problems/lian-xu-zi-shu-zu-de-zui-da-he-lcof/solution/lian-xu-zi-shu-zu-de-zui-da-he-by-leetco-tiui/
来源：力扣（LeetCode）
著作权归作者所有。商业转载请联系作者获得授权，非商业转载请注明出处。
*/
public class Solutioncopy {
    //分治法，逼格拉满
    public class Status {
        public int lSum, rSum, mSum, iSum;
        public Status(int lSum_, int rSum_, int mSum_, int iSum_) {
            lSum = lSum_; rSum = rSum_; mSum = mSum_; iSum = iSum_;
        }
    }

    public Status pushUp(Status l, Status r) {
        int iSum = l.iSum + r.iSum;
        int lSum = Math.Max(l.lSum, l.iSum + r.lSum);
        int rSum = Math.Max(r.rSum, r.iSum + l.rSum);
        int mSum = Math.Max(Math.Max(l.mSum, r.mSum), l.rSum + r.lSum);
        return new Status(lSum, rSum, mSum, iSum);
    }

    public Status getInfo(int[] a, int l, int r) {
        if (l == r) {
            return new Status(a[l], a[l], a[l], a[l]);
        }
        int m = (l + r) >> 1;
        Status lSub = getInfo(a, l, m);
        Status rSub = getInfo(a, m + 1, r);
        return pushUp(lSub, rSub);
    }

    public int MaxSubArray(int[] nums) {
        return getInfo(nums, 0, nums.Length - 1).mSum;
    }
}
/*
作者：LeetCode-Solution
链接：https://leetcode.cn/problems/lian-xu-zi-shu-zu-de-zui-da-he-lcof/solution/lian-xu-zi-shu-zu-de-zui-da-he-by-leetco-tiui/
来源：力扣（LeetCode）
著作权归作者所有。商业转载请联系作者获得授权，非商业转载请注明出处。
*/