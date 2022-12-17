
// Definition for a Node.
public class Node
{
    public int val;
    public IList<Node> children;

    public Node() { }

    public Node(int _val)
    {
        val = _val;
    }

    public Node(int _val, IList<Node> _children)
    {
        val = _val;
        children = _children;
    }
}
public class Solution2
{
    public IList<IList<int>> LevelOrder(Node root)
    {//用什么栈，用队列啊
        IList<IList<int>> res = new List<IList<int>>();
        if (root == null) return res;
        Queue<Node> q = new Queue<Node>();
        q.Enqueue(root);
        while (q.Count > 0)
        {
            int cnt = q.Count;
            List<int> temp = new List<int>();
            for (int i = 0; i < cnt; i++)
            {
                Node curr = q.Dequeue();//记录该层结点数，一次性处理
                temp.Add(curr.val);
                foreach(Node ch in curr.children) q.Enqueue(ch);//退一个把他的孩子结点全部取出
            }
            res.Add(temp);
        }
        return res;
        /*List<int> templist=new List<int>();
        if(root==null) return null;
        node.Push(root);templist.Add(root.val);
        res.Add(templist);templist.Clear();
        Node curr=root;
        while(node.Count>0)
        {
            curr=node.Pop();   
            for(int i=0;i<curr.children.Count;i++) {node.Push(curr.children[i]);templist.Add(curr.children[i].val);}
            //foreach(Node i in curr.children) {node.Push(i);templist.Add(i.val);}
            res.Add(templist);
            templist.Clear();
        }
        return res;*/
    }
}