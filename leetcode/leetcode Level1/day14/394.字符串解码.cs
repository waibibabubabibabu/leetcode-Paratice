public class Solution
{
    public string DecodeString(string s)
    {
        string res = "";
        string tmp = "";
        int mul = 0;
        //if(s.Length>0&&!(s[0]>='0'&&s[0]<='9')) return s;//无需解码
        for (int i = 0; i < s.Length; i++)
        {
            if (s[i]>='0'&&s[i]<='9') mul = s[i] - '0'+mul*10;
            else if(s[i]=='[')//开始解码
            {
                int count = 0; tmp = ""; i++;
                while (s[i] != ']' || count != 0)
                {
                    if (s[i] == '[') count++;
                    if(s[i]==']') count--;
                    tmp += s[i];
                    i++;
                }
                tmp=DecodeString(tmp);
                for (int j = 0; j < mul; j++) res += tmp;
                mul=0;//重置
                //i++;//把]跳过
            }
            else res+=s[i];
        }
        return res;
    }
}