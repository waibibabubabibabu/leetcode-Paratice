
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

public class BSTIterator
{
    Queue<TreeNode> queue = new Queue<TreeNode>();//一次性塞入到队列或者数组中，用数组或者队列本身的性质调用next 和hasnext
    Stack<TreeNode> stack;//用堆栈迭代进行
    public BSTIterator(TreeNode root)
    {
        stack = new Stack<TreeNode>();
        TreeNode curr = root;
        while (curr != null)
        {
            stack.Push(curr);
            curr = curr.left;
        }

    }

    public int Next()
    {
        TreeNode temp = stack.Pop();
        if (temp.right != null)
        {
            stack.Push(temp.right);
            while (stack.Peek().left != null) stack.Push(stack.Peek().left);//如何避免重复做工作}
        }
        return temp.val;
    }
    public bool HasNext()
    {
        if (stack.Count == 0) return false;
        else return true;
    }
}

/**
 * Your BSTIterator object will be instantiated and called as such:
 * BSTIterator obj = new BSTIterator(root);
 * int param_1 = obj.Next();
 * bool param_2 = obj.HasNext();
 */