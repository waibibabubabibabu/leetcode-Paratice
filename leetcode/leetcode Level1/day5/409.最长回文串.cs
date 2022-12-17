public class Solution {
    public int LongestPalindrome(string s) {
        //最长的长度等于偶数的字符组合加最大的奇数？
        int []vocabulary=new int[26*2];
        for(int i=0;i<s.Length;i++)
        {
            if(s[i]-'a'<26&&s[i]-'a'>=0)  vocabulary[(int)(s[i]-'a')]++;
            else vocabulary[(int)(s[i]-'A'+26)]++;
           
        }
        int maxLength=0;//maxOdd=0;//不是maxodd,odd减一后也能用
        int flag=0;//有没有奇数出现
        //不用flag也行，不过要在第一次遇见奇数的时候加进去，然后之后判断结果是奇数就不能再加了
        for(int i=0;i<52;i++)
        {
            if(vocabulary[i]%2==0) maxLength+=vocabulary[i];
            else {maxLength+=vocabulary[i]-1;flag=1;}
        }
        return maxLength+flag;
    }
}