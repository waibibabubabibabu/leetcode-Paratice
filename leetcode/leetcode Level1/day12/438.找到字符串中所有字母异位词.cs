public class Solution1
{
    public IList<int> FindAnagrams(string s, string p)//可以重排的匹配，构建字典去找，或者用数组维护也行
    {
       IList<int> res = new List<int>();
        if (s.Length < p.Length) return res;
        int[] pVocbulary = new int[26];
        foreach (char i in p) pVocbulary[i - 'a']++;
        int[] sVocbulary = new int[26];
        int index = 0;
        while (index < p.Length-1) { sVocbulary[(int)(s[index] - 'a')]++; index++; }
        while (index < s.Length)
        {
            sVocbulary[(int)(s[index++] - 'a')]++;
            if (sVocbulary.SequenceEqual(pVocbulary)) res.Add(index - p.Length);
            sVocbulary[(int)(s[index - p.Length] - 'a')]--;  
        }
        return res;
    }
}