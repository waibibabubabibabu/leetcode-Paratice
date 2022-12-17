public class Solution1 {
    public IList<bool> CheckArithmeticSubarrays(int[] nums, int[] l, int[] r) {//傻瓜方法，对每一个的子数组进行排序然后判断
    int count=l.Length;
    var res=new List<bool>();
    for(int i=0;i<count;i++)
    {
        res.Add(judge(nums,l[i],r[i]));
    }
    return res;
    }
    public bool judge(int[]nums,int start,int end)
    {
        if(end-start<1) return false;
        int []sub=new int[end-start+1];
        Array.Copy(nums,start,sub,0,end-start+1);
        Array.Sort(sub);
        int div=sub[1]-sub[0];
        for(int i=1;i<sub.Length-1;i++) if(sub[i+1]-sub[i]!=div) return false;
        return true;
    }
}