/* The isBadVersion API is defined in the parent class VersionControl.*/
      

public class Solution {
    bool IsBadVersion(int version)
    {
        if(version>=3) return true;
        else return false;
    }
    public int FirstBadVersion(int n) {//边界问题
    
        int left=1,right=n,mid;
        while(left!=right)//利用区间的收敛，将区间缩减
        {
            mid=(right-left)/+left;
            if(IsBadVersion(mid)==false) left=mid+1;
            else right=mid;//保留是自身的可能性
        }
        return left;
    }
}