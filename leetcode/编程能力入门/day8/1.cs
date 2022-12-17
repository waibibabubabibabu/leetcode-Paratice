using System;
namespace Leecode{
    class Solution1
    {
         public string MergeAlternately(string word1, string word2) {
        List<char> merge=new List<char>();
        int len1=word1.Length,len2=word2.Length;
        int i,j;
        for(i=0,j=0;i<word1.Length&&j<word2.Length;i++,j++)
        {
            merge.Add(word1[i]);
            merge.Add(word2[j]);
        }
        string res=string.Join("",merge);
        if(len1==len2) return res;
        else if(len1>len2) return res+word1.Substring(i);
        else return res+word2.Substring(j);
    }
    }
}