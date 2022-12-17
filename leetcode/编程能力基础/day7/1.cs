public class Solution1
{
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
            for (int i = 0; i < matrix.Length-1-ceng*2; i++)
            {
                //记录上侧
                temp2=matrix[0+ceng][i+ceng];
                //左侧
                matrix[0+ceng][i+ceng] = matrix[len - 1 - (i+ceng)][ceng];
                //下侧
                matrix[len - 1 - (i+ceng)][ceng] = matrix[len - 1-ceng][len - 1 - (i+ceng)];
                //右侧
                matrix[len - 1-ceng][len - 1 - (i+ceng)] = matrix[(i+ceng)][len - 1-ceng];
                //还原上侧至右侧
                matrix[i+ceng][len - 1-ceng]=temp2;
            }
            //for (int i = 0; i < len-2*ceng; i++) matrix[i+ceng][len - 1-ceng] = temp[i+ceng];
        }
    }
}