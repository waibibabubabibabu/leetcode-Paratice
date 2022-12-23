public class Solution
{
    public IList<IList<int>> LevelOrder(TreeNode root)
    {
        //嫌麻烦的话直接对ansTmp直接reverse，不然再创建一个stack，两个数据结构交替
        //或者用双端队列，在C#库中就是双端链表linkedlist
        /*
        LinkedList<int> TwoSideQueue=new LinkedList<int>();
        TwoSideQueue.RemoveFirst();
        TwoSideQueue.RemoveLast();
        */
        Queue<TreeNode> queue = new Queue<TreeNode>();
        IList<IList<int>> ans = new List<IList<int>>();
        if (root == null) return ans;
        queue.Enqueue(root);
        int ceng = 0;
        while (queue.Count != 0)
        {
            int Count = queue.Count;
            IList<int> ansTmp = new List<int>();
            ceng++;
            while (Count-- != 0)
            {
                TreeNode tmp = queue.Dequeue();
                ansTmp.Add(tmp.val);
                if (tmp.left != null) queue.Enqueue(tmp.left);
                if (tmp.right != null) queue.Enqueue(tmp.right);
            }
            if (ceng % 2 == 0)
            {
                int[] tmpa = ansTmp.ToArray();
                Array.Reverse(tmpa);
                ans.Add(tmpa.ToList());
            }
            else ans.Add(ansTmp);

        }
        return ans;
    }
}