/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */
public class Solution2
{
    public bool IsSameTree(TreeNode p, TreeNode q) {
        if(p!=null&&q!=null)
        {
            if(p.val!=q.val) return false;
            return IsSameTree(q.left,p.left)&&IsSameTree(q.right,p.right);
        }
        else if(p==null&&q==null) return true;
        else return false;
    }
    public void reverse(TreeNode root)
    {
        if(root!=null)
        {
            TreeNode tmp=root.left;
            root.left=root.right;
            root.right=tmp;
            reverse(root.left);
            reverse(root.right);
        }
    }
    public bool IsSymmetric(TreeNode root)
    {
        reverse(root.right);
        //不用翻转的话，移动指针要进行同步
        //具体方法可以用递归，也可以用迭代（queue）
        return IsSameTree(root.left,root.right);
    }
    public bool IsSymmetric1(TreeNode root)//费稿
    {
        //层序遍历？
        Queue<TreeNode> queue = new Queue<TreeNode>();
        Stack<int> stack = new Stack<int>();
        queue.Enqueue(root);
        while (queue.Count != 0)
        {
            int count = queue.Count;
            for (int i = 0; i < count; i++)
            {
                TreeNode tmp = queue.Dequeue();
                if (tmp == null) { queue.Enqueue(null); queue.Enqueue(null); }
                if (count != 1)
                {
                    if (count % 2 != 0) return false;
                    else
                    {
                        if (i < count / 2)
                        {
                            if (tmp == null) stack.Push(0);
                            else stack.Push(tmp.val);
                        }
                        else 
                        {
                            if(tmp==null) if(stack.Pop()!=0) return false;
                            else if (stack.Pop() != tmp.val) return false;
                        }

                    }
                }
                if (tmp != null)
                {
                    queue.Enqueue(tmp.left);
                    queue.Enqueue(tmp.right);
                }
            }
        }
        return true;
    }
}