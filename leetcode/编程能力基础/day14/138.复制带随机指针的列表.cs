
// Definition for a Node.
public class Node
{
    public int val;
    public Node next;
    public Node random;

    public Node(int _val)
    {
        val = _val;
        next = null;
        random = null;
    }
}


public class Solutioncopy21
{
    Dictionary<Node, Node> cachedNode = new Dictionary<Node, Node>();//两个对应的是新旧

    public Node CopyRandomList(Node head)
    {
        if (head == null)
        {
            return null;
        }
        if (!cachedNode.ContainsKey(head))
        {//已经含有了就不用再次添加了，归功于random
            Node headNew = new Node(head.val);
            cachedNode.Add(head, headNew);
            headNew.next = CopyRandomList(head.next);//用递归即可
            headNew.random = CopyRandomList(head.random);
        }
        return cachedNode[head];
    }
}
public class Solutioncopy22
{
    public Node CopyRandomList(Node head)//思路很简单，类似于抄作业
    {
        Dictionary<Node, Node> dic = new Dictionary<Node, Node>();
        Node temp = head;
        Node pre = new Node(0);
        pre.next = temp;
        if (head == null) return pre.next;
        while (temp != null)//抄作业题目
        {
            dic.Add(temp, new Node(temp.val));
            temp = temp.next;
        }
        foreach (var x in dic)//抄答案
        {
            if (x.Key.next != null)
            {
                x.Value.next = dic[x.Key.next];
            }
            else
            {
                x.Value.next = null;
            }

            if (x.Key.random != null)
            {
                x.Value.random = dic[x.Key.random];
            }
            else
            {
                x.Value.random = null;
            }
        }
        return dic[head];

    }
}