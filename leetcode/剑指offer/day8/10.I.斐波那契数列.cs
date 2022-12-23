public class Solution1
{
    public int Fib(int n)
    {
        long i=0,j=1;
        if(n<=1) return n;
        long ans=0;
        while(n-2>=0)
        {
            ans=(long)((i+j)%(1e9+7));
            i=j;
            j=ans;
            n--;
        }
        return (int)ans;
    }
    /*
    public int Fib2(int n)
    {
        //直接递归会导致递归栈溢出
        //数学
        int[][] mat = new int[2][];
        mat[0] = new int[] { 1, 1 };
        mat[1] = new int[] { 2, 1 };
        for (int i = 0; i < n - 1; i++) mat = Multiply(mat, mat);
    }
    */
}