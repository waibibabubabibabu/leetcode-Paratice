public class Solution2 {
    public int NextGreaterElement(int n) {
        int len=n.ToString().Length;
        if(len==1) return n;
        int temp=n;
        int[] nums=new int[len];
        for(int i=len-1;i>=0;i--)  {nums[i]=temp%10; temp/=10;}
        for(int i=len-1;i>=0;i--)//算法错误
        {
            for(int j=i-1;j>=0;j--)
            {
                if(nums[i]>nums[j])
                {
                    temp=nums[i];
                    nums[i]=nums[j];
                    nums[j]=temp;
                    i=-1;//强制退出
                    j=-1;
                }
            }
            if(i==0) return -1;//找不到
        }
        int res=0;
        for(int i=0;i<len;i++) res=res*10+nums[i];
        return res;
    }
}
public class Solutioncopy {
    public int NextGreaterElement(int n) {//出现了降序就开始换
    //（需要记录前一个数字）
    //（说明一定有小于但是在左边的a[i-1]）
    //（然后从前面中找到最接近的但是小于a[i-1]的数）
    //（交换完别忘翻转，使升序数组变成降序，使得数字更小）
        char[] nums = n.ToString().ToCharArray();
        int i = nums.Length - 2;
        while (i >= 0 && nums[i] >= nums[i + 1]) {
            i--;
        }
        if (i < 0) {
            return -1;
        }

        int j = nums.Length - 1;
        while (j >= 0 && nums[i] >= nums[j]) {
            j--;
        }
        Swap(nums, i, j);
        Reverse(nums, i + 1);
        long ans = long.Parse(new string(nums));
        return ans > int.MaxValue ? -1 : (int) ans;
    }

    public void Reverse(char[] nums, int begin) {
        int i = begin, j = nums.Length - 1;
        while (i < j) {
            Swap(nums, i, j);
            i++;
            j--;
        }
    }

    public void Swap(char[] nums, int i, int j) {
        char temp = nums[i];
        nums[i] = nums[j];
        nums[j] = temp;
    }
}
public class Solutioncopy2 {//将数字原地处理，思路跟上面基本一致，就需要引用O（1）空间（创建临时变量记录n的值就行）
    public int NextGreaterElement(int n) {
        int x = n, cnt = 1;
        for (; x >= 10 && x / 10 % 10 >= x % 10; x /= 10) {
            ++cnt;
        }
        x /= 10;
        if (x == 0) {
            return -1;
        }

        int targetDigit = x % 10;
        int x2 = n, cnt2 = 0;
        for (; x2 % 10 <= targetDigit; x2 /= 10) {
            ++cnt2;
        }
        x += x2 % 10 - targetDigit; // 把 x2 % 10 换到 targetDigit 上

        for (int i = 0; i < cnt; ++i, n /= 10) { // 反转 n 末尾的 cnt 个数字拼到 x 后
            int d = i != cnt2 ? n % 10 : targetDigit;
            if (x > int.MaxValue / 10 || x == int.MaxValue / 10 && d > 7) {
                return -1;
            }
            x = x * 10 + d;//翻转
        }
        return x;
    }
}