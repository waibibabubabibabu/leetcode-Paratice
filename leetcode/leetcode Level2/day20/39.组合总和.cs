public class Solution1
{
    HashSet<string> hash=new HashSet<string>();
    public IList<IList<int>> CombinationSum(int[] candidates, int target)
    {
        IList<IList<int>> ans = new List<IList<int>>();
        int[] tmp=new int[]{};
        do
        {
            tmp=dps(candidates,new int[candidates.Length],target);
            if(tmp!=null)
            {
                IList<int> tmpList=new List<int>();
                for(int i=0;i<tmp.Length;i++) while(tmp[i]--!=0) tmpList.Add(candidates[i]);
                ans.Add(tmpList);
            }
        }while(tmp!=null);
        return ans;
    }
    public int[]dps(int[]candidates,int[]nowCount,int target)
    {
        if(target<0) return null;
        string nowCountToString=string.Join("",nowCount);
        if(target==0&&!hash.Contains(nowCountToString)){
            hash.Add(nowCountToString);
            return nowCount;
        } 
        int []tmp=new int[]{};
        for(int i=0;i<nowCount.Length;i++)//循环查找浪费时间
        {
            nowCount[i]++;
            tmp=dps(candidates,nowCount,target-candidates[i]);
            if(tmp!=null) return tmp;
            nowCount[i]--;
        } 
        return null;
    }
}
class Solutioncopy {
    public IList<IList<int>> combinationSum(int[] candidates, int target) {
        IList<IList<int>> ans = new List<IList<int>>();
        IList<int> combine = new List<int>();
        Dfs(candidates, target, ans, combine, 0);
        return ans;
    }

    public void Dfs(int[] candidates, int target, IList<IList<int>> ans, IList<int> combine, int idx) {
        if (idx == candidates.Length) {
            return;
        }
        if (target == 0) {
            ans.Add(new List<int>(combine));
            return;
        }
        // 直接跳过
        Dfs(candidates, target, ans, combine, idx + 1);
        // 选择当前数
        if (target - candidates[idx] >= 0) {
            combine.Add(candidates[idx]);
            Dfs(candidates, target - candidates[idx], ans, combine, idx);
            combine.Remove(candidates[idx]);
        }
    }
}
/*
作者：LeetCode-Solution
链接：https://leetcode.cn/problems/combination-sum/solution/zu-he-zong-he-by-leetcode-solution/
来源：力扣（LeetCode）
著作权归作者所有。商业转载请联系作者获得授权，非商业转载请注明出处。*/