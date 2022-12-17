using System;
namespace Leecode{
    class Solution4{
        public bool AreAlmostEqual(string s1, string s2) {
           HashSet<char> Seens1=new HashSet<char>();
           HashSet<char> Seens2=new HashSet<char>();
           for(int i=0;i<s1.Length;i++)
           {
            if(s1[i]!=s2[i]) 
            {
                if(Seens1.Count==0)
                {
                    Seens1.Add(s1[i]);Seens2.Add(s2[i]);
                }
                else{
                    if(Seens1.Count==1)//第二次
                    {
                    if(Seens1.Contains(s2[i])&&Seens2.Contains(s1[i]))
                        {
                        Seens1.Add(s1[i]);Seens2.Add(s2[i]);
                        } 
                    else return false;
                    }
                    else return false;
                }
            }
           }
           if(Seens1.Count==1) return false;
           return true;
    }
    }
}