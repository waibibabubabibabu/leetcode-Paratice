using System;
public class Solution2 {
    public IList<int> AddToArrayForm1(int[] num, int k) {
        IList<int> res=new List<int>();
        /*int index=num.Length-1;
        int jin=0,temp=0;
        while(k!=0&&index>=0){
            temp=num[index]+k%10+jin;
            if(temp>10) jin=1;
            else jin=0;
            res.Add(temp%10);
            index++;k/=10;
        }*/
        string kString=k.ToString();
        string numString=string.Join("",num);
        int len1=kString.Length,len2=numString.Length;
        if(len1<len2) for(int i=0;i<len2-len1;i++) kString="0"+kString;
        else for(int i=0;i<len1-len2;i++) numString="0"+numString;
        int temp=0,jin=0;
        for(int i=Math.Max(len1,len2)-1;i>=0;i--)
        {
            temp=jin+(int)(kString[i]-'0')+(int)(numString[i]-'0');
            if(temp>=10)jin=1;
            else jin=0;
            res.Add(temp%10);
        }
        if(jin==1) res.Add(1);
        res.Reverse();
        return res;

        //问题：Ilist无法翻转
        //res.Reverse();
        //res=new List<int>(res.Reverse());
        //return (IList<int>)res;
        /*int[] kArray=new int[];
        int index=0; 
        while(k!=0){
            kArray[index]=k%10;
            k/=10;
            index++;*/
        }
        public IList<int> AddToArrayForm(int[] num, int k) {
            var res=new List<int>();
            for(int i=num.Length-1;i>=0||k>0;i--,k/=10)
            {
                if(i>=0) k+=num[i];//k=0,会从num补充
                res.Add(k%10);
            }
            res.Reverse();
            return res;
        }
    }