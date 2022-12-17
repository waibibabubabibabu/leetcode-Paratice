public class Solution
{
    public int CharacterReplacement(string s, int k)
    {
        //创建表，来确定每一个字符的最长子串，然后比较
        /*
        Dictionary<char, IList<int>> dictionary = new Dictionary<char, IList<int>>();
        for (int j = 0; j < s.Length; j++)//构建数组表
        {
            if (dictionary.ContainsKey(s[j]) == false) { dictionary.Add(s[j], new List<int>()); }
            dictionary[s[j]].Add(j);
        }
        for (int i = 0; i < 26; i++)
        {
            char vo++cabulary = (char)(i + 'A');
            if (dictionary.ContainsKey(vocabulary))//字典有的话参与最大值计算
            {
                IList<int> tmpList = dictionary[vocabulary];
                while(tmpList!=null)
                {

                }
            }
        }*/
        //写着写着发现和暴力查找没有什么两样
        //官方提示，双指针滑动窗口
        int left = 0, right = 0;
        //初始化辅助
        int[] count = new int[26];
        int maxcount = 0;
        int res=0;
        for (int i = 0; i < s.Length; i++)
        {
            //右移是每一步都要做的
            count[s[right] - 'A']++;
            if (count[s[right] - 'A'] > maxcount) maxcount = count[s[right] - 'A'];
            right++;
            if(right-left>maxcount+k)
            {
               count[s[left] - 'A']--;
               //只减去122的话maxcount的效力不受影响，因为如果新加了1个字符导致max归属变化，maxcount仍然是当前值
               //eg. A:3 B:2
               //减了A,A:2,B:2
               //如果right是B，加了B，A:2 B:3
               //maxcount仍是3，不过归属变成了B
               left++;
            }
            res=Math.Max(res,right-left);
        }
        return res;
    }
}