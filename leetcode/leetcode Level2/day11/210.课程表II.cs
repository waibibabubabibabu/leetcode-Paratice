public class Solution1
{
    public int[] FindOrder(int numCourses, int[][] prerequisites)
    {
        Dictionary<int, List<int>> dic = new Dictionary<int, List<int>>();
        Queue<int> queue = new Queue<int>();
        bool[] Courses = new bool[numCourses];
        int[] indegree = new int[numCourses];
        int[] ans = new int[numCourses];
        //要找到根节点，即没有先修要求的课程
        foreach (int[] i in prerequisites)
        {
            Courses[i[0]] = true;
            indegree[i[0]]++;
            if (dic.ContainsKey(i[1]) == false) dic.Add(i[1], new List<int>());
            dic[i[1]].Add(i[0]);

        }
        int count = 0;
        for (int i = 0; i < numCourses; i++)
            if (Courses[i] == false)
                queue.Enqueue(i);

        //开始递归
        while (queue.Count != 0)//类二叉树的广度优先搜索
        {
            int tmp = queue.Dequeue();
            if (dic.ContainsKey(tmp))
            {
                foreach (int i in dic[tmp])
                {
                    if (Courses[i])
                    {
                        indegree[i]--;
                        if (indegree[i] == 0)
                        {
                            queue.Enqueue(i);
                            Courses[i] = false;
                        }
                    }
                }
            }
            ans[count] = tmp;
            count++;
        }
        if (count != numCourses) return new int[] { };
        return ans;
    }
}