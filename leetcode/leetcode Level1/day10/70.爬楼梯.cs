public class Solution2
{
    public int ClimbStairs(int n)
    {//果然，单纯的递归会超出时间限制
        if (n == 1) return 1;
        if (n == 2) return 2;
        return ClimbStairs(n - 1) + ClimbStairs(n - 2);
    }
    public int ClimbStairs1(int n)//动态规划，优化版类似于同文件夹的509，仅使用三个数字，不再赘述
    {
        if (n < 3) return n;
        int[] climb = new int[n + 1];
        climb[1] = 1; climb[2] = 2;
        for (int i = 3; i < n + 1; i++) climb[i] = climb[i - 1] + climb[i - 2];
        return climb[n];
    }
    public int ClimbStairs2(int n)
    {//矩阵快速幂
        if (n < 3) return n;
        int[][] q = new int[2][];
        q[0] = new int[] { 1, 1 };
        q[1] = new int[] { 1, 0 };
        int[][] res = pow(q, n);//上一题是运行n-1次，因为上一题的F（0）=0；
        return res[0][0];
    }
    public int[][] pow(int[][] a, int n)
    {
        int[][] ret = new int[2][];
        ret[0] = new int[] { 1, 0 };
        ret[1] = new int[] { 0, 1 };
        //单位矩阵
        while (n > 0)
        {
            if ((n & 1) == 1) ret = multiply(ret, a);
            n >>= 1;
            a = multiply(a, a);//自身呈2的指数幂上升
        }
        return ret;
    }
    public int[][] multiply(int[][] a, int[][] b)
    {
        int[][] c = new int[2][];
        c[0]=new int[2];
        c[1]=new int[2];
        for (int i = 0; i < 2; i++) {
            for (int j = 0; j < 2; j++) {
                c[i][j] = a[i][0] * b[0][j] + a[i][1] * b[1][j];
            }
        }
        return c;
    }
    //通项表达式不再赘述
}