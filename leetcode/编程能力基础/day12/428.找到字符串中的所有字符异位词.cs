public class Solution1
{
    public IList<int> FindAnagrams(string s, string p)
    {
        //路子很多
        //char []sList=s.ToCharArray();
        char[] pList = p.ToCharArray();
        Array.Sort(pList);
        p = string.Join("", pList);
        //HashSet<char> hashSetP=new HashSet<char>();
        //foreach(char i in p) hashSetP.Add(p[i]);
        IList<int> res = new List<int>();
        for (int i = 0; i < s.Length - p.Length + 1; i++)//完全不处理结果超时了
        {
            //if(hashSetP.Contains(sList[i])==true)//开始滑动窗口
            string subs = s.Substring(i, p.Length);//字符串不能修改
            char[] subsList = subs.ToCharArray();
            Array.Sort(subsList);
            subs = string.Join("", subsList);
            if (subs == p) res.Add(i);
        }


        return res;

    }
    public IList<int> FindAnagrams2(string s, string p)//滑动窗口的关键思想在于可以维护
    {
        IList<int> res = new List<int>();
        if (s.Length < p.Length) return res;
        int[] pVocbulary = new int[26];
        foreach (char i in p) pVocbulary[i - 'a']++;
        int[] sVocbulary = new int[26];
        int index = 0;
        while (index < p.Length - 1) { sVocbulary[(int)(s[index] - 'a')]++; index++; }
        while (index < s.Length)
        {
            sVocbulary[(int)(s[index++] - 'a')]++;
            if (sVocbulary.SequenceEqual(pVocbulary)) res.Add(index - p.Length);
            sVocbulary[(int)(s[index - p.Length] - 'a')]--;
        }
        return res;
    }
}
public class Solution1copy {//引入diff
    public IList<int> FindAnagrams(string s, string p) {
        int sLen = s.Length, pLen = p.Length;

        if (sLen < pLen) {
            return new List<int>();
        }

        IList<int> ans = new List<int>();
        int[] count = new int[26];
        for (int i = 0; i < pLen; ++i) {
            ++count[s[i] - 'a'];
            --count[p[i] - 'a'];
        }

        int differ = 0;
        for (int j = 0; j < 26; ++j) {
            if (count[j] != 0) {
                ++differ;
            }
        }

        if (differ == 0) {
            ans.Add(0);
        }

        for (int i = 0; i < sLen - pLen; ++i) {
            if (count[s[i] - 'a'] == 1) {  // 窗口中字母 s[i] 的数量与字符串 p 中的数量从不同变得相同
                --differ;
            } else if (count[s[i] - 'a'] == 0) {  // 窗口中字母 s[i] 的数量与字符串 p 中的数量从相同变得不同
                ++differ;
            }
            --count[s[i] - 'a'];

            if (count[s[i + pLen] - 'a'] == -1) {  // 窗口中字母 s[i+pLen] 的数量与字符串 p 中的数量从不同变得相同
                --differ;
            } else if (count[s[i + pLen] - 'a'] == 0) {  // 窗口中字母 s[i+pLen] 的数量与字符串 p 中的数量从相同变得不同
                ++differ;
            }
            ++count[s[i + pLen] - 'a'];
            
            if (differ == 0) {
                ans.Add(i + 1);
            }
        }

        return ans;
    }
}

/*作者：LeetCode-Solution
链接：https://leetcode.cn/problems/find-all-anagrams-in-a-string/solution/zhao-dao-zi-fu-chuan-zhong-suo-you-zi-mu-xzin/
来源：力扣（LeetCode）
著作权归作者所有。商业转载请联系作者获得授权，非商业转载请注明出处。*/