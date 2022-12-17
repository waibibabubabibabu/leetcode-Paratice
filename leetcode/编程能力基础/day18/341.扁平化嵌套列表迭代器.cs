public class NestedIterator
{
    Stack<NestedInteger> stack;
    public NestedIterator(IList<NestedInteger> nestedList)
    {
        stack = new Stack<NestedInteger>(nestedList.ToArray().Reverse());
    }
    public bool HasNext()
    {
        start:
        if (stack.Count == 0)
            return false;
        else
        {
            if (stack.Peek().IsInteger())
                return true;
            else
            {
                var list = stack.Pop().GetList();
                for (int i = list.Count - 1; i >= 0; i--)//从后向前推
                    stack.Push(list[i]);
                goto start;
            }
        }
    }
    public int Next()//调用next的前提是hasnext过，说明一定会有int型的数字
    {
        return stack.Pop().GetInteger();
    }
}

/*作者：inficer
链接：https://leetcode.cn/problems/flatten-nested-list-iterator/solution/czhan-by-inficer-mmf2/
来源：力扣（LeetCode）
著作权归作者所有。商业转载请联系作者获得授权，非商业转载请注明出处。*/


//评论区解答2，因为查询的次数偏多，因此倾向将计算放在next内，
public class NestedIterator {
    private Stack<NestedInteger> _stack;
    private int? _next;

    public NestedIterator(IList<NestedInteger> nestedList) {
        _stack = new Stack<NestedInteger>();
        foreach (var l in Enumerable.Reverse(nestedList))
        {
            _stack.Push(l);
        }
        
        // 既然决定了实现接口的方向，那么在这里构造的时候支付一次代价
        _next = -1; // fake to start
        Next();//先进行一次，以将_next结果保留，并且保证hasnext正常工作
    }
    
    public bool HasNext() {
        return _next != null;
    }

    public int Next() {
        // 如果HasNext没有被正确使用，这样就可以保护使用者见到Exception而不是有非预期行为
        // 按照接口，如果没有用HasNext使用Next是非预期的行为。报错了还能修，这样不影响上层依赖这个基础类的逻辑的debug
        if (_next == null) {
            throw new Exception("Iterator is exhausted.");
        }
        var ans = (int)_next;//将上一次的_next当做结果，在for循环后进行输出
        
        _next = null;
        while (_stack.Count() > 0 && _next == null) {
            var cur = _stack.Pop();
            if (cur.IsInteger()) {
                _next = cur.GetInteger();
            } else {
                foreach (var l in Enumerable.Reverse(cur.GetList()))
                {
                    _stack.Push(l);
                }
            }
        }
        return ans;
    }
}

/*作者：guan-xiao-erick
链接：https://leetcode.cn/problems/flatten-nested-list-iterator/solution/cshi-xian-zheng-que-li-jie-jie-kou-by-guan-xiao-er/
来源：力扣（LeetCode）
著作权归作者所有。商业转载请联系作者获得授权，非商业转载请注明出处。*/