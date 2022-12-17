public class MyCalendar {//线段树，也就是被预定的行程区间内都赋值1，然后判断的时候只需要看区间内是否有1即可
    ISet<int> tree;
    ISet<int> lazy;

    public MyCalendar() {
        tree = new HashSet<int>();
        lazy = new HashSet<int>();
    }

    public bool Book(int start, int end) {
        if (Query(start, end - 1, 0, 1000000000, 1)) {
            return false;
        }
        Update(start, end - 1, 0, 1000000000, 1);
        return true;
    }

    public bool Query(int start, int end, int l, int r, int idx) {
        if (start > r || end < l) {
            return false;
        }
        /* 如果该区间已被预订，则直接返回 */
        if (lazy.Contains(idx)) {
            return true;
        }
        if (start <= l && r <= end) {
            return tree.Contains(idx);
        } else {//二分法
            int mid = (l + r) >> 1;
            if (end <= mid) {
                return Query(start, end, l, mid, 2 * idx);
            } else if (start > mid) {
                return Query(start, end, mid + 1, r, 2 * idx + 1);
            } else {
                return Query(start, end, l, mid, 2 * idx) | Query(start, end, mid + 1, r, 2 * idx + 1);
            }
        }
    }

    public void Update(int start, int end, int l, int r, int idx) {
        if (r < start || end < l) {
            return;
        } 
        if (start <= l && r <= end) {
            tree.Add(idx);
            lazy.Add(idx);
        } else {
            int mid = (l + r) >> 1;
            Update(start, end, l, mid, 2 * idx);
            Update(start, end, mid + 1, r, 2 * idx + 1);
            tree.Add(idx);
        }
    }
}

/*作者：LeetCode-Solution
链接：https://leetcode.cn/problems/my-calendar-i/solution/wo-de-ri-cheng-an-pai-biao-i-by-leetcode-nlxr/
来源：力扣（LeetCode）
著作权归作者所有。商业转载请联系作者获得授权，非商业转载请注明出处。*/

class MyCalendar1 {

    public MyCalendar1() {

    }
    
    public bool book(int start, int end) {
        // 先查询该区间是否为 0
        if (query(root, 0, N, start, end - 1) != 0) return false;
        // 更新该区间
        update(root, 0, N, start, end - 1, 1);
        return true;
    }
    // *************** 下面是模版 ***************
    public class Node {
        // 左右孩子节点
        public Node left, right;
        // 当前节点值，以及懒惰标记的值
        public int val, add;
    }
    private int N = (int) 1e9;//很大的数字
    private Node root = new Node();
    public void update(Node node, int start, int end, int l, int r, int val) {
        if (l <= start && end <= r) {
            node.val += val;
            node.add += val;
            return ;
        }
        pushDown(node);
        int mid = (start + end) >> 1;
        if (l <= mid) update(node.left, start, mid, l, r, val);
        if (r > mid) update(node.right, mid + 1, end, l, r, val);
        pushUp(node);
    }
    public int query(Node node, int start, int end, int l, int r) {
        if (l <= start && end <= r) return node.val;
        pushDown(node);
        int mid = (start + end) >> 1, ans = 0;
        if (l <= mid) ans = query(node.left, start, mid, l, r);
        if (r > mid) ans = Math.Max(ans, query(node.right, mid + 1, end, l, r));
        return ans;
    }
    private void pushUp(Node node) {
        // 每个节点存的是当前区间的最大值
        node.val = Math.Max(node.left.val, node.right.val);
    }
    private void pushDown(Node node) {
        if (node.left == null) node.left = new Node();
        if (node.right == null) node.right = new Node();
        if (node.add == 0) return ;
        node.left.val += node.add;
        node.right.val += node.add;
        node.left.add += node.add;
        node.right.add += node.add;
        node.add = 0;
    }
}
/*
作者：lfool
链接：https://leetcode.cn/problems/my-calendar-i/solution/by-lfool-xvpv/
来源：力扣（LeetCode）
著作权归作者所有。商业转载请联系作者获得授权，非商业转载请注明出处。*/