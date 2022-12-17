using System;
namespace LeeCode{
    class Solution2{
         public string FreqAlphabets(string s) {
            List<char> news=new List<char>();
            int temp;
            char ch;
            for(int i=s.Length-1;i>=0;i--)
            {
                if(s[i]=='#')
                {
                    temp=(int)(s[i-1]-'0')+10*(int)(s[i-2]-'0')-1;
                    i-=2;
                    ch=Convert.ToChar(temp+'a');
                    news.Add(ch);
                }
                else{
                    news.Add((char)((int)s[i]-'0'+'a'-1));
                }
            }
            news.Reverse();
            return string.Join("",news);
        
    }
    private string NumberToChar(int num)
    {
        if(num>=1&&num<=26)
        {
            num+=96;
            System.Text.ASCIIEncoding ascll=new System.Text.ASCIIEncoding();
            byte[] btNumber=new byte[1];
            btNumber[0]=Convert.ToByte(num);
            return ascll.GetString(btNumber);
        }
        else return"数字不在转换范围之内";
    }
    }
}