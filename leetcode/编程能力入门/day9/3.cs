using System;
namespace LeeCode{
    class Solution3{
        public bool IsAlienSorted(string[] words, string order) {
            if(words.Length==1) return true;
            Dictionary<char,int> orderDic=new Dictionary<char, int>();
            for(int i=0;i<order.Length;i++) orderDic.Add(order[i],i);
            for(int i=1;i<words.Length;i++)
            {
                int j=0;
                string s1=words[i-1],s2=words[i];
                while(j<s1.Length&&j<s2.Length)
                {
                    if(orderDic[s1[j]]>orderDic[s2[j]]) return false;
                    if(orderDic[s1[j]]<orderDic[s2[j]]) break;
                    j++;
                }
                if(s1.Length>s2.Length&&j==s2.Length) return false;
            }
            return true;
    }
    }
}