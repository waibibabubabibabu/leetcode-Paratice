using System;
namespace Leecode{
    class program{
        static void Main(string[] args)
        {
            Solution2 s2=new Solution2();
            int r=1,c=4;
            int[][] mat=new int[2][];
            mat[0]=new int[]{1,2};
            mat[1]=new int[]{3,4};
            int[][]res=new int[r][];
            res[0]=new int[c];
            res=s2.MatrixReshape(mat,r,c);
        }
    }
}