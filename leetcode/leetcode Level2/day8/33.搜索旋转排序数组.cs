
public class Solution1
{
    public int Search(int[] nums, int target)
    {
        //Ҫ��ʱ�临�Ӷ���logn
        int start = nums[0];
        if (nums.Length == 1)
        {
            if (start == target) return 0;
            else return -1;
        }
        //���ֲ��Ҳ�֪����ʼ�����ֹ��������
        //�ȶ��ֲ����е�
        //��֪������
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
        ������һ��Ϊ��������һ����һ��������ģ���һ������������Ҳ���ǲ�������
        ��ʱ���򲿷��ö��ַ����ҡ����򲿷���һ��Ϊ��������һ��һ��������һ���������򣬿������򡣾�����ѭ��. 
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

/*���ߣ�LeetCode-Solution
���ӣ�https://leetcode.cn/problems/search-in-rotated-sorted-array/solution/sou-suo-xuan-zhuan-pai-xu-shu-zu-by-leetcode-solut/
��Դ�����ۣ�LeetCode��
����Ȩ���������С���ҵת������ϵ���߻����Ȩ������ҵת����ע��������*/