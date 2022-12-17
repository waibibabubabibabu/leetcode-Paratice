public class Solution1 {
    public string LongestCommonPrefix1(string[] strs) {//纵向扫描
        string ans="";
        if(strs[0].Length==0) return ans;
        int j=0;
        while(true)
        {
            if(j>=strs[0].Length) return ans;
            char tmp=strs[0][j];
            foreach(string i in strs)
            {
                if(j>=i.Length||i[j]!=tmp) return ans;
            }
            ans+=tmp;
            j++;
        }
    }
    //横向扫描
    //LCP(S1,S4)=LCP(LCP(LCP(S1,S2)S3)S4)
    //递归：基于横向扫描，进行分治
    //二分查找,实用性不高

}