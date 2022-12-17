public class Solution
{
    public int[][] Merge(int[][] intervals)
    {
        //先排序
        Comparer<int[]> comparer = Comparer<int[]>.Create(
            (a, b) =>  a[0].CompareTo(b[0])
        );
        Array.Sort(intervals, comparer);
        List<int[]> anslist = new List<int[]>();
        int left = intervals[0][0];
        int right = intervals[0][1];
        for (int i = 1; i < intervals.Length; i++)
        {
            if (right >= intervals[i][0])
            {
                left = Math.Min(left, intervals[i][0]);
                right = Math.Max(right, intervals[i][1]);
            }
            else
            {
                anslist.Add(new int[] { left, right });
                left = intervals[i][0];
                right = intervals[i][1];
            }
        }
        anslist.Add(new int[] { left, right });
        int[][] ans = new int[anslist.Count][];
        for (int i = 0; i < anslist.Count; i++) ans[i] = anslist[i];
        return ans;
    }
}