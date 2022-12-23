public class Solution2 {
    public int NumWays(int n) {
        if(n==0) return 1;
        if(n<=2) return n;
        long MOD=(long)1e9+7;
        long ans=2;
        long i=1,j=2;
        while(n-2>0)
        {
            ans=(long)((i+j)%MOD);
            i=j;
            j=ans;
            n--;
        }
        return (int)ans;
    }
}