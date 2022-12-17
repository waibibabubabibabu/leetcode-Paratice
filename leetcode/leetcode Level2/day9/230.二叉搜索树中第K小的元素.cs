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
    
    Stack<TreeNode> stack;
    //二叉树的中序遍历
    public int KthSmallest(TreeNode root, int k)
    {
        TreeNode curr = root;
        stack = new Stack<TreeNode>();
        while (true)
        {
            while (curr != null)
            {
                stack.Push(curr);
                curr = curr.left;
            }
            curr=stack.Pop();
            k--;
            if(k==0) return curr.val;
            else if(curr.right!=null) curr=curr.right;
            else curr=null;//防止重复推入
        }
        return -1;
    }
}
//如果是要重复查询第k小的，可以建立hash，存储字树的节点数，以便后边遍历，第一次需要初始化
public class Solutioncopy {
    public int KthSmallest(TreeNode root, int k) {
        MyBst bst = new MyBst(root);
        return bst.KthSmallest(k);
    }
}

class MyBst {
    TreeNode root;
    Dictionary<TreeNode, int> nodeNum;

    public MyBst(TreeNode root) {
        this.root = root;
        this.nodeNum = new Dictionary<TreeNode, int>();
        CountNodeNum(root);
    }

    // 返回二叉搜索树中第k小的元素
    public int KthSmallest(int k) {
        TreeNode node = root;
        while (node != null) {
            int left = GetNodeNum(node.left);
            if (left < k - 1) {
                node = node.right;
                k -= left + 1;
            } else if (left == k - 1) {
                break;
            } else {
                node = node.left;
            }
        }
        return node.val;
    }

    // 统计以node为根结点的子树的结点数
    private int CountNodeNum(TreeNode node) {
        if (node == null) {
            return 0;
        }
        nodeNum.Add(node, 1 + CountNodeNum(node.left) + CountNodeNum(node.right));
        return nodeNum[node];
    }

    // 获取以node为根结点的子树的结点数
    private int GetNodeNum(TreeNode node) {
        return node != null && nodeNum.ContainsKey(node) ? nodeNum[node] : 0;
    }
}
/*
作者：LeetCode-Solution
链接：https://leetcode.cn/problems/kth-smallest-element-in-a-bst/solution/er-cha-sou-suo-shu-zhong-di-kxiao-de-yua-8o07/
来源：力扣（LeetCode）
著作权归作者所有。商业转载请联系作者获得授权，非商业转载请注明出处。*/