public class NumMatrix {
    int [][]sum;
    public NumMatrix(int[][] matrix) {//二维的前缀和，也可以用概率统计中的思想
    int len1=matrix.Length;
    int len2=matrix[0].Length;
    sum=new int[len1+1][];
    for(int i=0;i<len1+1;i++) sum[i]=new int[len2+1];
    //构建sum矩阵
    for(int i=1;i<len1+1;i++)
    {
        for(int j=1;j<len2+1;j++)
        {
            sum[i][j]=matrix[i-1][j-1]+sum[i][j-1]+sum[i-1][j]-sum[i-1][j-1];
        }
    }
    }
    
    public int SumRegion(int row1, int col1, int row2, int col2) {
        int res=sum[row2+1][col2+1]-sum[row1][col2+1]-sum[row2+1][col1]+sum[row1][col1];
        return res;
    }
}

/**
 * Your NumMatrix object will be instantiated and called as such:
 * NumMatrix obj = new NumMatrix(matrix);
 * int param_1 = obj.SumRegion(row1,col1,row2,col2);
 */