using System;
namespace Leecode{
    class Solution1
    {
         public int DiagonalSum(int[][] mat) {
            int Sum=0;
            for(int i=0;i<mat.Length;i++)
            {
                Sum+=mat[i][i]+mat[i][mat.Length-1-i];
            }
            if(mat.Length%2!=0)//需要减去重复的元素
            {
                int index=(mat.Length-1)/2;
                Sum-=mat[index][index];
            }
            return Sum;
    }
    }
}