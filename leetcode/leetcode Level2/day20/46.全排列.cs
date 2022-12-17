public class Solution
{
    public IList<IList<int>> Permute(int[] nums)
    {
        IList<IList<int>> ans = new List<IList<int>>();
        IList<int> combine = new List<int>();
        bool[]used=new bool[nums.Length];
        dfs(ans,combine,nums,0,0,used);
        return ans;
    }
    public void dfs(IList<IList<int>> ans,IList<int> combine,int[] nums,int count,int index,bool[]used)
    {
        //违法
        if(index==nums.Length) {index=index%3;dfs(ans,combine,nums,count,index,used);}
        if(count==nums.Length){
            ans.Add(combine);
            return;
        }
         //不处理
        dfs(ans,combine,nums,count,index+1,used);
         //加入index
        if(!used[index])
        {
            used[index]=true;
            combine.Add(nums[index]);
            dfs(ans,combine,nums,count+1,index,used);
            combine.Remove(nums[index]);
            used[index]=false;
        }
        //dfs(ans,combine,nums,count,index-1,used);
        
    }
}
class Solutioncopy1 {
    public IList<IList<int>> Permute(int[] nums) {
        IList<IList<int>> res = new List<IList<int>>();

        IList<int> output = new List<int>();
        foreach (int num in nums) {
            output.Add(num);
        }

        int n = nums.Length;
        backtrack(n, output, res, 0);
        return res;
    }

    public void backtrack(int n, IList<int> output, IList<IList<int>> res, int first) {
        // 所有数都填完了
        if (first == n) {
            res.Add(new List<int>(output));
        }
        for (int i = first; i < n; i++) {//O（n）复杂度在这里
            // 动态维护数组
            //i是待填写的数，填入到前半部分，然后等撤销后循环
            swap(output, first, i);
            // 继续递归填下一个数
            backtrack(n, output, res, first + 1);
            // 撤销操作
            swap(output, first, i);
        }
    }
    public void swap(IList<int> output,int first,int i)
    {
        int tmp=output[first];
        output[first]=output[i];
        output[i]=tmp;
    }
}
/*
作者：LeetCode-Solution
链接：https://leetcode.cn/problems/permutations/solution/quan-pai-lie-by-leetcode-solution-2/
来源：力扣（LeetCode）
著作权归作者所有。商业转载请联系作者获得授权，非商业转载请注明出处。*/