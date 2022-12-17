public class Solution
{
    public int[][] Insert(int[][] intervals, int[] newInterval)
    {
        //Comparer<int[]> comparer=Comparer<int[]>.Create(
        //    (a,b)=>a[0].CompareTo(b[0])
        //);
        //Array.Sort(intervals,comparer);
        //int index=Array.BinarySearch(intervals,newInterval,comparer);
        int left = newInterval[0];
        int right = newInterval[1];
        bool placed = false;
        List<int[]> anslist = new List<int[]>();
        foreach (int[] interval in intervals)
        {
            if (interval[0] > right)//在插入区间的右侧且没有交集
            {
                if (!placed)
                {
                    anslist.Add(new int[] { left, right });
                    placed = true;
                }
                anslist.Add(interval);
            }
            else if (interval[1] < left)//在插入区间的左侧且没有交集
            {
                anslist.Add(interval);
            }
            else
            {
                //与插入区间有交集，并且计算并集
                left = Math.Min(left, interval[0]);
                right = Math.Max(right, interval[1]);
            }
        }
        if (!placed) anslist.Add(new int[] { left, right });
        int[][] ans = new int[anslist.Count][];
        for (int i = 0; i < anslist.Count; i++) ans[i] = anslist[i];
        return ans;
    }
}