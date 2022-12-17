
//Definition for a binary tree node.
public class TreeNode
{
    public int val;
    public TreeNode left;
    public TreeNode right;
    public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
    {
        this.val = val;
        this.left = left;
        this.right = right;
    }
}

public class Solution
{
    IList<IList<int>> res;
    IList<int> tempres;
    int count;//用来统计该层共有多少个节点，控制队列输出
    Queue<TreeNode> queue;
    public IList<IList<int>> LevelOrder(TreeNode root)
    {
        //层序遍历
        res = new List<IList<int>>();
        queue = new Queue<TreeNode>();
        if(root==null) return res;
        queue.Enqueue(root); count = 1;//初始化方便控制
        while (queue.Count > 0)
        {
            int tempcount=0;
            tempres=new List<int>();
            while (count > 0)
            {
                TreeNode temp = queue.Dequeue();
                if (temp.left != null) {queue.Enqueue(temp.left);tempcount++;}
                if (temp.right != null) {queue.Enqueue(temp.right);tempcount++;}
                count--;
                tempres.Add(temp.val);
            }
            count=tempcount;//其实可以获取当前queue的size，等于tempcount
            //count=queue.Count();
            res.Add(tempres);
        }
        return res;
    }
}