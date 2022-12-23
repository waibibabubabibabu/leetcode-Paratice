class Solution1 {
    public bool IsSubStructure(TreeNode A, TreeNode B) {
        return (A != null && B != null) && (recur(A, B) || IsSubStructure(A.left, B) || IsSubStructure(A.right, B));
    }
    bool recur(TreeNode A, TreeNode B) {
        if(B == null) return true;
        if(A == null || A.val != B.val) return false;
        return recur(A.left, B.left) && recur(A.right, B.right);
    }
}
/*
作者：jyd
链接：https://leetcode.cn/problems/shu-de-zi-jie-gou-lcof/solution/mian-shi-ti-26-shu-de-zi-jie-gou-xian-xu-bian-li-p/
来源：力扣（LeetCode）
著作权归作者所有。商业转载请联系作者获得授权，非商业转载请注明出处。*/