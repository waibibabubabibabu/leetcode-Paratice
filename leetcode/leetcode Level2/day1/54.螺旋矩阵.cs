public class Solution2
{
    public IList<int> SpiralOrder(int[][] matrix)
    {
        //能假设修改原矩阵，不能的话，创建一个同样大小的矩阵进行记录
        IList<int> res = new List<int>();
        int i = 0, j = 0;
        int count = 0;//记录次数
        //int mode = 0;
        /*
        0:右移
        1:下移
        2:左移
        3:上移
        */
        while (count < matrix.Length * matrix[0].Length-1)
        {
            //切换模式
            //0->1
            while (true)
            {
                if (j == matrix[0].Length - 1 || matrix[i][j + 1] == -101) break;
                res.Add(matrix[i][j]);count++;
                matrix[i][j] = -101;
                j++;
            }
            //1->2
            while (true)
            {
                if (i == matrix.Length - 1 || matrix[i + 1][j] == -101) break;
                res.Add(matrix[i][j]);count++;
                matrix[i][j] = -101;
                i++;
            }
            //2->3
            while (true)
            {
                if (j == 0 || matrix[i][j - 1] == -101) break;
                res.Add(matrix[i][j]);count++;
                matrix[i][j] = -101;
                j--;
            }
            //3->0
            while (true)
            {
                if (i == 0 || matrix[i - 1][j] == -101) break;
                res.Add(matrix[i][j]);count++;
                matrix[i][j] = -101;
                i--;
            }
        }
        res.Add(matrix[i][j]);
        return res;
    }
    //法2：修改四个边界的值，紧缩为一个点输出后，如果上边大于下边，或者左边大于右边，return res（上面的判断语句的i==0更换成i==up）
}