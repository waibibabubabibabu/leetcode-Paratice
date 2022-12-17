public class Solution {
    public bool SearchMatrix(int[][] matrix, int target) {
        //高级二分，先列后行
        int rowLeft=0,rowRight=matrix.Length-1;
        while(rowLeft!=rowRight)//向左收缩，right--
        {
            int mid=(int)Math.Ceiling((double)(rowRight-rowLeft)/2+rowLeft) ;//向左收缩，mid向上取整，可以在括号内部+1，同样的原理
            if(target>=matrix[mid][0]) rowLeft=mid;
            else rowRight=mid-1;
        }
        int columnLeft=0,columnRight=matrix[rowLeft].Length-1;
        int []tmp=matrix[rowLeft];
        while(columnLeft<=columnRight)//收缩至一点
        {
            int mid=(columnRight-columnLeft)/2+columnLeft;
            if(tmp[mid]==target) return true;
            if(target>tmp[mid]) columnLeft=mid+1;
            else columnRight=mid-1;
        }
        return false;
    }
}