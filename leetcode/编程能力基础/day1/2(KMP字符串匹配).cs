public class Solution2 {
    public int StrStr(string haystack, string needle) {
        if(needle.Length>haystack.Length) return -1;
        for(int i=0;i<haystack.Length;i++)
        {
            if(haystack[i]==needle[0])//开始匹配
            {
                int j=0;
                while(j<needle.Length&&j+i<haystack.Length)
                {
                    if(haystack[j+i]!=needle[j]) break;
                    j++;
                }
                if(j==needle.Length) return i;
                i+=j;
            }
        }
        return -1;
    }
    public int KMP(string haystack,string needle){
        if(needle.Count()==0) return 0;
        int n=haystack.Length,m=needle.Length;
        haystack=" "+haystack;needle=" "+needle;

        int[] next=new int[needle.Length+1];//Leecode宫水三叶：KMP算法
        for(int i=2,j=0;i<=m;i++)
        {
            //匹配不成功的话，j=next(j)
            while(j>0&&needle[i]!=needle[j+1]) j=next[j];
             // 匹配成功的话，先让 j++
            if(needle[i]==needle[j+1]) j++;
            // 更新 next[i]，结束本次循环，i++
            next[i]=j;
        }
        for(int i=1,j=0;i<=n;i++)
        {
            while(j>0&&haystack[i]!=needle[j+1])j=next[j];
            if(haystack[i]==needle[j+1]) j++;
            if(j==m) return i-m;
        }
        return -1;
    }
}