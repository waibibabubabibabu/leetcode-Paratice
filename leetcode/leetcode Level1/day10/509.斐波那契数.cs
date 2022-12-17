public class Solution1
{
    public int Fib(int n)
    {//狗都会
        if (n == 0) return 0;
        else if (n == 1) return 1;
        else return Fib(n - 1) + Fib(n - 2);
    }
    public int Fib1(int n)
    {//动态规划
        if (n == 0) return 0;
        else if (n == 1) return 1;
        int[] dynamicProgramming = new int[n + 1];
        dynamicProgramming[0] = 0;
        dynamicProgramming[1] = 1;
        for (int i = 2; i < n + 1; i++)
            dynamicProgramming[i] = dynamicProgramming[i - 1] + dynamicProgramming[i - 2];
        return dynamicProgramming[n];
    }
    public int Fib2(int n)//动态规划滚动数组版(仅需要三个额外空间)
    {
        int p = 0, q = 1, r = 1;
        if (n == 0) return p;
        if (n == 1) return q;
        for (int i = 2; i < n + 1; i++)
        {
            r = q + p;
            p = q;
            q = r;
        }
        return r;
    }
    public int Fib3(int n)//矩阵快速幂
    {
        if (n < 2) return n;
        int[][] q = new int[2][];
        q[0] = new int[] { 1, 1 };
        q[1] = new int[] { 1, 0 };
        int[][] res = pow(q, n - 1);
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
}