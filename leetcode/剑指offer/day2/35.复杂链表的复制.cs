
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

public class Solution
{
    public Node CopyRandomList(Node head)
    {
        if(head==null) return null;
        List<Node> origin = new List<Node>();
        while (head != null)
        {
            origin.Add(head);
            head = head.next;
        }
        List<Node> newList = new List<Node>();
        //抄写题目
        foreach (Node i in origin)
            newList.Add(new Node(i.val));
        //抄写答案
        for (int i = 0; i < newList.Count; i++)
        {
            if (i != newList.Count - 1) newList[i].next = newList[i + 1];
            //newList[i].random=origin[i].random;
            int index = origin.IndexOf(origin[i].random);
            if (index == -1) newList[i].random = null;
            else newList[i].random = newList[index];
        }
        return newList[0];
    }
}
public class Solutioncopy {
        //用dic进行对应
    Dictionary<Node, Node> cachedNode = new Dictionary<Node, Node>();

    public Node CopyRandomList(Node head) {
        if (head == null) {
            return null;
        }
        if (!cachedNode.ContainsKey(head)) {
            Node headNew = new Node(head.val);
            cachedNode.Add(head, headNew);
            headNew.next = CopyRandomList(head.next);
            headNew.random = CopyRandomList(head.random);
        }
        return cachedNode[head];
    }
}
/*
作者：LeetCode-Solution
链接：https://leetcode.cn/problems/fu-za-lian-biao-de-fu-zhi-lcof/solution/fu-za-lian-biao-de-fu-zhi-by-leetcode-so-9ik5/
来源：力扣（LeetCode）
著作权归作者所有。商业转载请联系作者获得授权，非商业转载请注明出处。*/

//由对应关系，在原链表的每一个结点后面插入一个新节点，用来代替dic的对应关系
public class Solutioncopy2 {
    public Node CopyRandomList(Node head) {
        if (head == null) {
            return null;
        }
        for (Node node = head; node != null; node = node.next.next) {
            Node nodeNew = new Node(node.val);
            nodeNew.next = node.next;
            node.next = nodeNew;
        }
        for (Node node = head; node != null; node = node.next.next) {
            Node nodeNew = node.next;
            nodeNew.random = (node.random != null) ? node.random.next : null;
        }
        Node headNew = head.next;
        for (Node node = head; node != null; node = node.next) {
            Node nodeNew = node.next;
            node.next = node.next.next;
            nodeNew.next = (nodeNew.next != null) ? nodeNew.next.next : null;
        }
        return headNew;
    }
}
/*
作者：LeetCode-Solution
链接：https://leetcode.cn/problems/fu-za-lian-biao-de-fu-zhi-lcof/solution/fu-za-lian-biao-de-fu-zhi-by-leetcode-so-9ik5/
来源：力扣（LeetCode）
著作权归作者所有。商业转载请联系作者获得授权，非商业转载请注明出处。*/