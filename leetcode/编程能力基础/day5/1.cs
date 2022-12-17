public class Solution1 {
    public string AddBinary(string a, string b) {
        string res="";int jin=0,temp=0;
        int len1=a.Length,len2=b.Length;
        if(len1>len2) for(int i=0;i<len1-len2;i++) b="0"+b;//补0
        else for(int i=0;i<len2-len1;i++) a="0"+a;
        for(int i=Math.Max(len1,len2)-1;i>=0;i--){
            temp=jin+(int)(a[i]-'0')+(int)(b[i]-'0');
            if(temp==3) {jin=1;res="1"+res;}
            else if(temp==2){jin=1;res="0"+res;}
            else if(temp==1){jin=0;res="1"+res;}
            else {jin=0;res="a0"+res;}
        }
        if(jin==1) res="1"+res;
        return res;
    }
}