using System.Numerics;
public class Solution1
{
    public IList<int> SpiralOrder(int[][] matrix)
    {
        var res = new List<int>();
        int indexX = 0, indexY = 0;
        int len = matrix.Length * matrix[0].Length;
        int Xlen = matrix[0].Length, Ylen = matrix.Length;
        int ceng = 0;//行数小于三，就是最后一次螺旋
        while (res.Count < len)
        {
            if((double)Ylen - (double)(ceng * 2) ==1||Ylen==1) //仅有一行，特殊处理
            {
                //indexY++;
                while(indexY<Xlen-ceng) res.Add(matrix[indexX][indexY++]);
                break;
            }
            if((double)Xlen - (double)(ceng * 2) ==1||Xlen==1) //仅有一列，特殊处理
            {
                //indexX++;//撤回第一个预处理
                while(indexX<Ylen-ceng) res.Add(matrix[indexX++][indexY]);
                break;
            }
            res.Add(matrix[indexX][indexY]); indexY++; //第一个进行预处理
            //以下为两行以上的处理
            if (indexY < Xlen - ceng)
            {
                while (indexY < Xlen - ceng) res.Add(matrix[indexX][indexY++]);
                indexY--; indexX++;
            }
            if (indexX < Ylen - ceng)
            {
                while (indexX < Ylen - ceng) res.Add(matrix[indexX++][indexY]);
                indexX--; indexY--;
            }
            if (indexY >= ceng)
            {
                while (indexY >= ceng) res.Add(matrix[indexX][indexY--]);
                indexY++; indexX--;
            }
            if (indexX >= ceng + 1)
            {
                while (indexX >= ceng + 1) res.Add(matrix[indexX--][indexY]);
                indexX++;
            }
            ceng++;
            if ((double)Ylen - (double)(ceng * 2) ==0||(double)Xlen - (double)(ceng * 2) ==0) break;
            else indexY++;//进入下一层??进入方法是这个？？
        }
        //res.Reverse();
        return res;
    }
}