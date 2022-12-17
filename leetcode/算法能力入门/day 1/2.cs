/* The IsBadVersion API is defined in the parent class VersionControl.
      bool IsBadVersion(int version); */
using System;
namespace Leecode{
    public class VersionControl{
        int bad;
        public bool IsBadVersion(int version)
        {
            if(version<=bad) return  true;
            else return false;
        }

        public void setBad(int i){bad=i;}
    }
/* The IsBadVersion API is defined in the parent class VersionControl.   bool IsBadVersion(int version); */

public class Solution2 : VersionControl {
     public int FirstBadVersion(int n) {
    int left=1,right=n;
    while(left<right)
    {
        int mid=left+(right-left)/2;
        if(IsBadVersion(mid))
        {
            right=mid;
        }
        else{
            left=mid+1;
        }
        
    }
    return left;
     }
}
}
