public class Solution
{
    /*
    给你一个用字符数组 tasks 表示的 CPU 需要执行的任务列表。其中每个字母表示一种不同种类的任务。任务可以以任意顺序执行，
    并且每个任务都可以在 1 个单位时间内执行完。在任何一个单位时间，CPU 可以完成一个任务，或者处于待命状态。
    然而，两个 相同种类 的任务之间必须有长度为整数 n 的冷却时间，因此至少有连续 n 个单位时间内 CPU 在执行不同的任务，或者在待命状态。
    你需要计算完成所有任务所需要的 最短时间 。
    */
    public struct Information
    {
        public int count;
        public int newtime;
        public int flag;
        public char elem;
        public Information()
        {
            elem='0';
            count = 0;
            newtime = 0;
            flag = 0;
        }
    }
    public int LeastInterval1(char[] tasks, int n)
    {
        int time = n;
        Information[] information = new Information[26];
        foreach (char i in tasks) {information[i - 'A'].count++;information[i - 'A'].elem=i;}
        PriorityQueue<Information, Information> heap = new PriorityQueue<Information, Information>(
            Comparer<Information>.Create((a, b) =>
            (a.flag == 0 && b.flag == 0) ? b.count.CompareTo(a.count) : b.flag.CompareTo(a.flag)
            )
        );
        foreach (Information info in information) if(info.elem!=0) heap.Enqueue(info, info);
        for (int i = 0; i < tasks.Count(); i++)
        {
            //小于的话可以直接执行
            //但是需要优先执行任务多的
            //用大顶堆维护？
            while (true)
            {
                Information tmp = heap.Dequeue();
                if (tmp.flag == -1 || tmp.count == 0) break;//表示全部任务都执行不了，直接退出循环
                if (time - tmp.newtime >= n) { tmp.newtime = time; tmp.count--; heap.Enqueue(tmp, tmp); break; } //可以执行
                else tmp.flag = -1;//表示现在不能执行
                heap.Enqueue(tmp, tmp);
            }
            time++;
            //将flag恢复原状
            //for (int j = 0; j < 26; j++) information[j].flag = 0;
            HashSet<Information> hashtemp=new HashSet<Information>();
            //flag无法变0，思路作废

        }
        return time;
    }
    public int LeastIntervalcopy(char[] tasks, int n)//桶排序思想，详见下面连接
    /*
    https://leetcode.cn/problems/task-scheduler/solution/tong-zi-by-popopop/
    */
    {
        int len=tasks.Length;
        int []vocabulary=new int[26];
        foreach(char c in tasks) ++vocabulary[c-'A'];
        Comparer<int> comparer=Comparer<int>.Create((a,b)=>b.CompareTo(a));
        Array.Sort(vocabulary,comparer);
        int cnt=1;
        while(cnt<vocabulary.Length&&vocabulary[cnt]==vocabulary[0]) cnt++;
        return Math.Max(len,cnt+(n+1)*(vocabulary[0]-1) );
    }
}