public class Solution {
    Dictionary<string,int> dictionary;
    PriorityQueue<string,KeyValuePair<string,int>> heap;
    public IList<string> TopKFrequent(string[] words, int k) {
        dictionary=new Dictionary<string, int>();
        heap=new PriorityQueue<string,KeyValuePair<string, int>>(
            //运用comparer创建比较组
            Comparer<KeyValuePair<string,int>>.Create((a,b)=>//a是要插入的元素，b是原有的元素,比较器=-1，a在b左边，否则a在b右边(默认从左到右)
            //先比次数，次数相等就看字母，字符小的优先；(大小是ascll码)
            //次数不等比次数，次数大的优先
            b.Value.CompareTo(a.Value)==0?a.Key.CompareTo(b.Key):b.Value.CompareTo(a.Value))
            //eg:b.value=5,a.value=4,b>a,比较器返回1，a插在b右边，符合题意
            
        );
        IList<string> ans=new List<string>();
        foreach(string i in words)
        {
            if(dictionary.ContainsKey(i)==false) dictionary.Add(i,1);
            else dictionary[i]++;
        }
        foreach(KeyValuePair<string,int> kvp in dictionary) heap.Enqueue(kvp.Key,kvp);
        for(int i=0;i<k;i++) ans.Add(heap.Dequeue());
        return ans;
    }
}
/*
PriorityQueue<string, KeyValuePair<string, int>> queue =
               new PriorityQueue<string, KeyValuePair<string, int>>(Comparer<KeyValuePair<string, int>>.Create((a, b) =>
               b.Value.CompareTo(a.Value) == 0 ? a.Key.CompareTo(b.Key) : b.Value.CompareTo(a.Value)));

作者：kukuni
链接：https://leetcode.cn/problems/top-k-frequent-words/solution/by-kukuni-6yr3/
来源：力扣（LeetCode）
著作权归作者所有。商业转载请联系作者获得授权，非商业转载请注明出处。
*/