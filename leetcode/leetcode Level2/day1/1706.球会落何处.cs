public class Solution {
    int[]answer;
    public int[] FindBall(int[][] grid) {
        answer=new int[grid[0].Length];
        //对answer初始化
        for(int i=0;i<answer.Length;i++) answer[i]=i;
        //开始掉落
        for(int i=0;i<grid.Length;i++)//开始向下滑动
        {
            if(answer.All(o=>o==-1)) return answer;
            for(int j=0;j<grid[0].Length;j++)
            {
                //=-1的已经被卡住了，直接跳过
                if(answer[j]!=-1)
                {
                    if(grid[i][answer[j]]==1)//正对角线
                    {
                        if(answer[j]==grid[0].Length-1||grid[i][answer[j]+1]==-1) answer[j]=-1;//被卡死了
                        else answer[j]++;
                    }
                    else{
                        if(answer[j]==0||grid[i][answer[j]-1]==1) answer[j]=-1;
                        else answer[j]--;
                    }
                }
            }
        }
        return answer;
    }
}