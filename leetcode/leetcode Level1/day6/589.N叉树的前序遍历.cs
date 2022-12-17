
// Definition for a Node.
public class Node {
    public int val;
    public IList<Node> children;

    public Node() {}

    public Node(int _val) {
        val = _val;
    }

    public Node(int _val,IList<Node> _children) {
        val = _val;
        children = _children;
    }
}


public class Solution1 {//还有队列写法，大同小异，不再赘述
IList<int> res;
    public IList<int> Preorder(Node root) {
        //前序遍历，中，左，右
        //递归写法
       res=new List<int>();
       PreorderRecurrence(root);
       return res;
    }
    public void PreorderRecurrence(Node root)
    {
        if(root!=null)
        {
            res.Add(root.val);
            foreach(Node i in root.children) PreorderRecurrence(i);
        }
    }
}