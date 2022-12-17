public class Solution1
{
    public bool IsIsomorphic(string s, string t)
    {
        Dictionary<int, int> dictionaryStoT = new Dictionary<int, int>();
        Dictionary<int, int> dictionaryTtoS = new Dictionary<int, int>();
        for (int i = 0; i < s.Length; i++)
        {

            if (dictionaryStoT.ContainsKey(s[i])) { if (dictionaryStoT[s[i]] != t[i]) return false; }
            else dictionaryStoT.Add(s[i], t[i]);
            if (dictionaryTtoS.ContainsKey(t[i])) { if (dictionaryTtoS[t[i]] != s[i]) return false; }
            else dictionaryTtoS.Add(t[i], s[i]);

        }
        return true;
    }
}