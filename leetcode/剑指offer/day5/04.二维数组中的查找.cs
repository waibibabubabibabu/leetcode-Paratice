public class Solution1 {
    public bool FindNumberIn2DArray(int[][] matrix, int target) {
        //双二分
        if(matrix.Length==0||matrix[0].Length==0) return false;
        int left=0,right=matrix.Length-1;
        //第一次找最后一个小于target的值
        int row=left;
        while(left<=right)
        {
            int mid=(left+right)>>1;
            if(matrix[mid][0]<=target)
            {
                if(matrix[mid][0]==target) return true;
                left=mid+1;
                row=mid;
            }
            else right=mid-1;
        }
        left=0;right=matrix[row].Length-1;
        int column=left;
        //找target所在的行
       while(left<=right)
        {
            int mid=(left+right)>>1;
            if(matrix[0][mid]<=target)
            {
                if(matrix[0][mid]==target) return true;
                left=mid+1;
                column=mid;
            }
            else right=mid-1;
        }
        for(int i=0;i<=row;i++)
        {
            for(int j=0;j<=column;j++)
            {
                if(matrix[i][j]==target) return true;
            }
        }
        return false;
    }
}
class Solutioncopy {
    //标志位算法
    public bool findNumberIn2DArray(int[][] matrix, int target) {
        int i = matrix.Length - 1, j = 0;
        while(i >= 0 && j < matrix[0].Length)
        {
            if(matrix[i][j] > target) i--;
            else if(matrix[i][j] < target) j++;
            else return true;
        }
        return false;
    }
}
/*
作者：jyd
链接：https://leetcode.cn/problems/er-wei-shu-zu-zhong-de-cha-zhao-lcof/solution/mian-shi-ti-04-er-wei-shu-zu-zhong-de-cha-zhao-zuo/
来源：力扣（LeetCode）
著作权归作者所有。商业转载请联系作者获得授权，非商业转载请注明出处。*/