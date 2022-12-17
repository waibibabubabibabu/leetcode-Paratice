public class Solution2
{
    public IList<IList<string>> GroupAnagrams(string[] strs)
    {//用hash表
        //strs.ToList();
        int[] flags = new int[strs.Length];//记录是否已经被访问
        var res = new List<IList<string>>();
        var tempres = new List<string>();
        int i = 0;
        while (i<strs.Length)
        {
            tempres = new List<string>();
            while (i<strs.Length&&flags[i] != 0){ i++;}
            if(i==strs.Length) break;
            string curr = strs[i];i++;
            tempres.Add(curr);
            int []vocabularyList=new int[26];
            foreach(char ch in curr) vocabularyList[(int)(ch-'a')]++;//创建单词表，用于比较
            for (int j = i; j < strs.Length ; j++)
            {
                if (flags[j] == 0&& judge(curr, strs[j],vocabularyList) == true) { tempres.Add(strs[j]); flags[j] = 1; }
            }
            res.Add(tempres);
        }
        return res;
    }
    public bool judge(string model,string item,int[] vocabularyList)
    {
        int[] tempVocabularyList=new int[26];
        Array.Copy(vocabularyList,tempVocabularyList,26);
        if(item.Length!=model.Length) return false;
        foreach(char i in item)
        {
             if(tempVocabularyList[(int)(i-'a')]==0) return false;
             else tempVocabularyList[(int)(i-'a')]--;
        }
        //通常，就有不通常的
        return true;
    }
}

public class Solution2Cpoy {
    public IList<IList<string>> GroupAnagrams(string[] strs) {//代码简短
        IDictionary<string, IList<string>> dictionary = new Dictionary<string, IList<string>>();
        foreach (string str in strs) {
            char[] array = str.ToCharArray();
            Array.Sort(array);
            string key = new string(array);
            dictionary.TryAdd(key, new List<string>());//已有就不加了，如果没有key就加进去
            dictionary[key].Add(str);
        }
        return new List<IList<string>>(dictionary.Values);
    }
}
/*
复杂度分析
时间复杂度：O(nk \log k)O(nklogk)，其中 nn 是数组 \textit{strs}strs 的长度，
kk 是数组 \textit{strs}strs 中的字符串的最大长度。需要遍历 nn 个字符串，每个字符串的排序和更新哈希表共需要 O(k \log k)O(klogk) 的时间，总时间复杂度是 O(nk \log k)O(nklogk)。

空间复杂度：O(nk)O(nk)，其中 nn 是数组 \textit{strs}strs 的长度，kk 是数组 \textit{strs}strs 中的字符串的最大长度。
哈希表需要存储数组 \textit{strs}strs 中的全部字符串，需要 O(nk)O(nk) 的空间。
*/
/*
作者：stormsunshine
链接：https://leetcode.cn/problems/group-anagrams/solution/by-stormsunshine-3mfw/
来源：力扣（LeetCode）
著作权归作者所有。商业转载请联系作者获得授权，非商业转载请注明出处。*/