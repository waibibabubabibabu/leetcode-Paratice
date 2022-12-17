using System;
namespace LeeCode{
public class Solution11 {
     public IList<int> Preorder(Node root) {
        IList<int> res=new List<int>();
        preOrder(root,res);
        return res;
    }
    void preOrder(Node root,IList<int> res)
    {
        if(root==null) return;
        res.Add(root.val);
        foreach(Node ch in root.children) preOrder(ch,res);
    }
}
public class Solution12
{
     public IList<int> Preorder(Node root) {
        IList<int> res=new List<int>();
        if(root==null) return res;
        Dictionary<Node,int> dictionary=new Dictionary<Node, int>();
        Stack<Node> stack=new Stack<Node>();
        Node node=root;
        while(stack.Count>0||node!=null){//先把结点与第一个子节点全部压进去
            while(node!=null)
            {
                res.Add(node.val);
                stack.Push(node);
                IList<Node> ChildrenList=node.children;
                if(ChildrenList!=null&&ChildrenList.Count>0)
                {
                    dictionary.Add(node,0);
                    node=ChildrenList[0];
                }else{
                    node=null;
                }
            }
            node=stack.Peek();
            int index=(dictionary.ContainsKey(node)?dictionary[node]:-1)+1;
            IList<Node> children=node.children;
            if(children!=null&&children.Count>index){
                dictionary[node]=index;//已有子节点的数目
                node=children[index];
            }else{
                stack.Pop();
                dictionary.Remove(node);
                node=null;
            }
        }
        return res;
        

     }
}

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
}