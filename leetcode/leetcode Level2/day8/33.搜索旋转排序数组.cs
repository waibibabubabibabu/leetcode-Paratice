
public class Solution1
{
    public int Search(int[] nums, int target)
    {
        //要求时间复杂度是logn
        int start = nums[0];
        if (nums.Length == 1)
        {
            if (start == target) return 0;
            else return -1;
        }
        //二分查找不知道起始点和终止点在哪里
        //先二分查找中点
        //已知是升序
        int left = 0; int right = nums.Length - 1;
        while (left != right)//logn
        {
            int mid = (right - left) / 2 + left;
            if (nums[mid] >= nums[0]) { left = mid; left++; }
            else right = mid;
        }

        //int max=nums[right];int min=nums[right-1];
        if (target >= nums[0]) { left = 0; }
        else { right = nums.Length - 1; }

        while (left <= right)
        {
            int mid = (right - left) / 2 + left;
            if (nums[mid] == target) return mid;
            if (nums[mid] < target) { left = mid; left++; }
            else { right = mid; right--; }
        }
        return -1;
    }
}
class Solutioncopy
{
    /*
        将数组一分为二，其中一定有一个是有序的，另一个可能是有序，也能是部分有序。
        此时有序部分用二分法查找。无序部分再一分为二，其中一个一定有序，另一个可能有序，可能无序。就这样循环. 
    */
    public int search(int[] nums, int target)
    {
        int n = nums.Length;
        if (n == 0)
        {
            return -1;
        }
        if (n == 1)
        {
            return nums[0] == target ? 0 : -1;
        }
        int l = 0, r = n - 1;
        while (l <= r)
        {
            int mid = (l + r) / 2;
            if (nums[mid] == target)
            {
                return mid;
            }
            if (nums[0] <= nums[mid])
            {
                if (nums[0] <= target && target < nums[mid])
                {
                    r = mid - 1;
                }
                else
                {
                    l = mid + 1;
                }
            }
            else
            {
                if (nums[mid] < target && target <= nums[n - 1])
                {
                    l = mid + 1;
                }
                else
                {
                    r = mid - 1;
                }
            }
        }
        return -1;
    }
}

/*作者：LeetCode-Solution
链接：https://leetcode.cn/problems/search-in-rotated-sorted-array/solution/sou-suo-xuan-zhuan-pai-xu-shu-zu-by-leetcode-solut/
来源：力扣（LeetCode）
著作权归作者所有。商业转载请联系作者获得授权，非商业转载请注明出处。*/