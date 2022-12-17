public class Solution2{
    public bool RepeatedSubstringPattern(string s) {
        //return (s + s).IndexOf(s, 1) != s.Length;
        return KMP(s.Substring(1)+s.Substring(0,s.Length-1),s)!=-1;

    }
    public int KMP(string str,string ppstr){
        if(ppstr.Count()==0) return 0;
        int n=str.Length,m=ppstr.Length;
        str=" "+str;ppstr=" "+ppstr;

        int[] next=new int[ppstr.Length+1];//Leecode宫水三叶：KMP算法
        for(int i=2,j=0;i<=m;i++)
        {
            //匹配不成功的话，j=next(j)
            while(j>0&&ppstr[i]!=ppstr[j+1]) j=next[j];
             // 匹配成功的话，先让 j++
            if(ppstr[i]==ppstr[j+1]) j++;
            // 更新 next[i]，结束本次循环，i++
            next[i]=j;
        }
        for(int i=1,j=0;i<=n;i++)
        {
            while(j>0&&str[i]!=ppstr[j+1])j=next[j];
            if(str[i]==ppstr[j+1]) j++;
            if(j==m) return i-m;
        }
        return -1;
    }

}