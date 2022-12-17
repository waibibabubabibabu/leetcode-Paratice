public class Solution
{
    public bool IsSubsequence(string s, string t)
    {
        if(s.Length==0) return true;
        if(t.Length==0) return false;
        //暴力求解，找到第一个字符后再创建一个指针依次寻找
        int shead = s[0],sIndex=0;
        for (int i = 0; i < t.Length; i++)
        {
            if (t[i] == shead)
            {
                int nextHeaIndex = i + 1;sIndex=0;//第一位已经找到了
                for (int j = i; j < t.Length; j++)
                {
                    if(t[j]==shead) nextHeaIndex=j;
                    if(t[j]==s[sIndex]) sIndex++;
                    if(sIndex==s.Length) return true;
                }
            }
        }
        return false;
    }
    public bool IsSubsequence1(string s, string t){
        //对于大量的子串，我们希望能在O（1）的时间内完成判断
        //因此需要预处理t，找到t[i]的26个英文字母下一次出现的位置
        //思想类似于第一次想象的26个list，不过用数组实现更直观
        int slen=s.Length,tlen=t.Length;
        int[,]dynamicProgramming=new int[t.Length+1,26];
        //由于dp[i][j]=dp[i+1][j]，所以初始化从后往前，并且最后一行用于
        for(int i=0;i<26;i++) dynamicProgramming[tlen,i]=tlen;//表示找不到就是到头了
        for(int i=tlen-1;i>=0;i--)
        {
            for(int j=0;j<26;j++)
            {
                if(t[i]=='a'+j) dynamicProgramming[i,j]=i;//表示在这行出现过
                else dynamicProgramming[i,j]=dynamicProgramming[i+1,j];//取上一行的
            }
        }
        int add=0;
        for(int i=0;i<slen;i++)
        {
            if(dynamicProgramming[add,s[i]-'a']==tlen) return false; //没找到
            else add=dynamicProgramming[add,s[i]-'a']+1;//向下一位
        }
        return true;
    }
}