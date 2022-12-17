using System;
class program
{
    static void Main(string[] args)
    {
        Solution1 s1 = new Solution1();
        int[][] matrix1 = new int[5][];
        matrix1[0] = new int[] { 1, 2, 3, 4, 5 };
        matrix1[1] = new int[] { 6, 7, 8, 9, 10 };
        matrix1[2] = new int[] { 11, 12, 13, 14, 15 };
        matrix1[3] = new int[] { 16, 17, 18, 19, 20 };
        matrix1[4] = new int[] { 21, 22, 23, 24, 25 };
        int[][] matrix2 = new int[1][];
        matrix2[0] = new int[] { 2, 3 };
        int[][] matrix3 = new int[2][];
        matrix3[0] = new int[] { 2 };
        matrix3[1] = new int[] { 3 };
        int[][] matrix4 = new int[4][];
        matrix4[0] = new int[] { 1, 2, 3 };
        matrix4[1] = new int[] { 4, 5, 6 };
        matrix4[2] = new int[] { 7, 8, 9 };
        matrix4[3] = new int[] { 10, 11, 12 };
        int[][] matrix5 = new int[4][];
        matrix5[0] = new int[] { 1, 2, 3, 4 };
        matrix5[1] = new int[] { 5, 6, 7, 8 };
        matrix5[2] = new int[] { 9, 10, 11, 12 };
        matrix5[3] = new int[] { 13, 14, 15, 16 };
        s1.SpiralOrder(matrix2);
    }
}