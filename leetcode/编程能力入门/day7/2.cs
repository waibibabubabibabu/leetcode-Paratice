using System;
namespace Leecode{
    class Solution2{
         public int[][] MatrixReshape(int[][] mat, int r, int c) {
            if(r*c!=mat.Length*mat[0].Length) return mat;
            List<int> newMat=new List<int>();
            for(int i=0;i<mat.Length;i++)
            {
                for(int j=0;j<mat[0].Length;j++)
                {
                    newMat.Add(mat[i][j]);
                }
            }
            int index=0;
            int [][]res=new int[r][];
            for(int i=0;i<r;i++)
            {
                res[i]=new int[c];
                for(int j=0;j<c;j++)
                {   
                    res[i][j]=newMat[index];
                    index++;
                }
            }
            return res;
    }
    }
}