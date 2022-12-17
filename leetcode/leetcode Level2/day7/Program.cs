class program
{
    static void Main()
    {
        Solution s = new Solution();
        string[] nums = new string[] { "10", "5", "-3", "3", "2", "null", "11", "3", "-2", "null", "1" };

        TreeNode root;
        Tree tree = new Tree();
        root = tree.createTree(nums);
        s.PathSum(root,8);
    }
}
class Tree
{
    public TreeNode createTree(string[] nums)
    {
        Queue<TreeNode> queue = new Queue<TreeNode>();
        TreeNode root = new TreeNode();
        queue.Enqueue(root);
        int ceng = 0;//表示层数
        int sum = nums.Length;
        int i = 0;//nums下标
        while (sum>0)
        {
            int tmp = (int)Math.Pow(2, ceng);//这层要赋值的个数
            for (int j = 0; j < tmp; j++,i++)
            {
                TreeNode tmpT = queue.Dequeue();
                if (nums[i] != "null") tmpT.val = Convert.ToInt32(nums[i]);
                if(sum>(int)Math.Pow(2, ceng))
                {
                    tmpT.left = new TreeNode();
                    tmpT.right = new TreeNode();
                    queue.Enqueue(tmpT.left);
                    queue.Enqueue(tmpT.right);
                }
            }
            sum-=tmp;
        }
        return root;
    }
}