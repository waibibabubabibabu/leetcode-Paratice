public class Solution2
{
    public bool FindRotation1(int[][] mat, int[][] target)
    {//借用上一题的方法，矩阵相等也是最基础的方法，似乎狗都不用的方法
        if (equal1(mat, target)) return true;
        for (int i = 0; i < 3; i++)
        {
            Rotate(mat);
            if (equal1(mat, target)) return true;
        }
        return false;
    }
    public bool equal1(int[][] mat1, int[][] mat2)
    {
        for (int i = 0; i < mat1.Length; i++)
        {
            for (int j = 0; j < mat1.Length; j++)
            {
                if (mat1[i][j] != mat2[i][j]) return false;
            }
        }
        return true;
    }
    public void Rotate(int[][] matrix)
    {
        //if(matrix.Length<=1) return ;//不需要了
        int len = matrix.Length;
        //double centery=(len-1)/2,centerx=centery;
        //int[] temp = new int[len];//官方解答这里是不允许使用矩阵的，但是可以简化temp2
        int temp2;
        for (int ceng = 0; ceng < matrix.Length / 2; ceng++)
        {
            // temp=new int[len];
            //for (int i = 0; i < len-2*ceng; i++) temp[i+ceng] = matrix[ceng][i+ceng];//把该层第一行存进去
            for (int i = 0; i < matrix.Length - 1 - ceng * 2; i++)
            {
                //记录上侧
                temp2 = matrix[0 + ceng][i + ceng];
                //左侧
                matrix[0 + ceng][i + ceng] = matrix[len - 1 - (i + ceng)][ceng];
                //下侧
                matrix[len - 1 - (i + ceng)][ceng] = matrix[len - 1 - ceng][len - 1 - (i + ceng)];
                //右侧
                matrix[len - 1 - ceng][len - 1 - (i + ceng)] = matrix[(i + ceng)][len - 1 - ceng];
                //还原上侧至右侧
                matrix[i + ceng][len - 1 - ceng] = temp2;
            }
            //for (int i = 0; i < len-2*ceng; i++) matrix[i+ceng][len - 1-ceng] = temp[i+ceng];
        }
    }
    public bool FindRotation2(int[][] mat, int[][] target)//比较简便的方法，不旋转的基础上进行逐位比较
    {
        int Angle = 0;
        if (equal2(mat, target, Angle) == true) return true;
        else Angle += 90; if (equal2(mat, target, Angle) == true) return true;
        else Angle += 90; if (equal2(mat, target, Angle) == true) return true;
        else Angle += 90; if (equal2(mat, target, Angle) == true) return true;
        else return false;
    }
    public bool equal2(int[][] mat1, int[][] mat2, int RotateAngle)
    {
        int len = mat1.Length;
        switch (RotateAngle / 90)
        {
            case 0:
                for (int i = 0; i < len; i++)
                {
                    for (int j = 0; j < len; j++)
                    {
                        if (mat1[i][j] != mat2[i][j]) return false;
                    }
                }
                return true;
                break;
            case 1:
                for (int i = 0; i < len; i++)
                {
                    for (int j = 0; j < len; j++)
                    {
                        if (mat1[i][j] != mat2[j][len - 1 - i]) return false;//顺时针旋转90度比较：x,y??y,len-1-x
                    }
                }
                return true;
                break;
            case 2:
                for (int i = 0; i < len; i++)
                {
                    for (int j = 0; j < len; j++)
                    {
                        if (mat1[i][j] != mat2[len - 1 - i][len - 1 - j]) return false;//顺时针旋转180度比较：x,y??len-1-y,len-1-x
                    }
                }
                return true;
                break;
            case 3:
                for (int i = 0; i < len; i++)
                {
                    for (int j = 0; j < len; j++)
                    {
                        if (mat1[i][j] != mat2[len - 1 - j][i]) return false;//顺时针旋转270度比较：x,y??len-1-y,x
                    }
                }
                return true;
                break;
        }
        return true;
    }
}