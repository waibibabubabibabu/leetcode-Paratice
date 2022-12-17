using System;
public class Solution3 {
    public bool IsAnagram(string s, string t) {
        if(s.Length!=t.Length) return false;
        Dictionary<char,int> dic=new Dictionary<char, int>();
        foreach(char i in s)
        {
            if(dic.ContainsKey(i)==false) dic.Add(i,1);
            else dic[i]++;
        }
        foreach(char j in t)
        {
            if(dic.ContainsKey(j)==false) return false;
            else if(dic[j]==1) dic.Remove(j);
            else dic[j]--;
        }
        
        return true;
    }
}