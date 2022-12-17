using System;
namespace Leecode{
    class Solution3{
         public char FindTheDifference(string s, string t) {
            Dictionary<char,int> temp2=new Dictionary<char, int>();
            foreach(char i in s)
            {
                if(temp2.ContainsKey(i)==true) temp2[i]++;
                else temp2.Add(i,0); 
            }
            foreach(char j in t)
            {
                if(temp2[j]==-1||temp2.ContainsKey(j)==false) return j;
                else{
                    temp2[j]--;
                }
            }
            return '0';
            /*HashSet<char> temp=new HashSet<char>();
            foreach (char i in s) temp.Add(i);
            foreach (char j in t) 
            {
                if(temp.Contains(j)==false) return j;
                else{
                    temp.Remove(j);//可能出现了两次
                }
            }
            return '0';*/
    }
    public char solution3(string s,string t)
    {
        int asclls=0,ascllt=0;
        foreach(char i in s) asclls+=i;
        foreach(char j in t) ascllt+=j;
        return (char)(ascllt-asclls);

    }
    }
}
