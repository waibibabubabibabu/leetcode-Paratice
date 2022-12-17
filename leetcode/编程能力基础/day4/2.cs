public class Solution2 {
    /*public string Multiply(string num1, string num2) {//摆明了不想让你用数字做，全程字符串
        long res=0,tempres=0;
        //int []tempRes=new int[Math.Max(num1.Length,num2.Length)+1];//顶天了进一位
        int len1=num1.Length;
        int len2=num2.Length;
        for(int i=len1-1;i>=0;i--)
        {
            tempres=0;
            for(int j=len2-1;j>=0;j--)
            {
                tempres+=((long)(num1[i]-'0')*(long)(num2[j]-'0'))*(long)Math.Pow(10,(len2-1-j));
            }
            res+=tempres*(long)Math.Pow(10,(len1-1-i));
        }
        return res.ToString();
    }*/
    public string Add(string num1,string num2)
    {
        string res="";
        int len1=num1.Length,len2=num2.Length;//涉及对齐的问题
        if(len1!=len2)
        {
            if(len1<len2)  for(int i=0;i<len2-len1;i++) num1="0"+num1;  //给num1补0
            else for(int i=0;i<len1-len2;i++) num2="0"+num2;
        }
        string jin="";
        for(int i=Math.Max(len1,len2)-1;i>=0;i--)
        {
            string tempstr1=num1.Substring(i,1);
            string tempstr2=num2.Substring(i,1);
            string tempstr=AtomAdd(tempstr1,tempstr2);
            if(tempstr.Length==2) tempstr="1"+AtomAdd(tempstr.Substring(1,1),jin);//此时的tempstr可能已经长度为2，会报错,所以只取最后一位
            else tempstr=AtomAdd(tempstr,jin);
            if(tempstr.Length==2) {
            jin="1";//需要进位
            tempstr=tempstr.Substring(1,1);
            }
            else jin="";
            res=tempstr+res;
        }

        /*int jin=0,temp=0;
        for(int i=0;i<len;i++)
        {
            temp=(int)(numa[i]-'0')+(int)(numb[i]-'0')+jin;
            if(temp<10) res+=temp.ToString();
            else {jin=temp/10; res+=(temp%10).ToString();}
        }*/
        //if(num1.Length<num2.Length) res+=num2.Substring(num1.Length);
        //else res+=num1.Substring(num2.Length);
        return jin+res;//可能最后有进位
    }
    public string AtomMultiply(string num1,string num2)
    {
        if(num1.Length!=0&&num2.Length!=0) return ((int)(num1[0]-'0')*(int)(num2[0]-'0')).ToString();
        else return "0";
    }
    public string AtomAdd(string num1,string num2)
    {
        if(num1.Length!=0&&num2.Length!=0)  return ((int)(num1[0]-'0')+(int)(num2[0]-'0')).ToString();
        else if(num2.Length!=0) return num2;
        else return num1;
    }
    public string Multiply(string num1, string num2)
    {
        string res2="",res1="";
        int len1=num1.Length;
        int len2=num2.Length;
        for(int i=0;i<len1;i++)
        {
            res1="";
            for(int j=0;j<len2;j++)
            {
                string tempstr1=num1.Substring(i,1);
                string tempstr2=num2.Substring(j,1);
                string tempstr=AtomMultiply(tempstr1,tempstr2);
                if(tempstr!="00"&&tempstr!="0") for(int count=0;count<len2-j-1;count++) tempstr+="0";
                res1=Add(res1,tempstr);
            }
            if(res1!="00"&&res1!="0") for(int count=0;count<len1-i-1;count++) res1+="0";//乘10
            res2=Add(res2,res1);
        }
        return res2;
    }
}