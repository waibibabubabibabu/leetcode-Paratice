using System;
namespace Leecode{
    class Solution1{
         public int HammingWeight(uint n) {
            if(n>0)
            {
                if(n%2==0) return HammingWeight(n>>1);
                else return HammingWeight(n>>1)+1;
            }
            else return 0;
    }
    public int HammingWeight2(uint n){
            uint res=0;
            while(n!=0)
            {
                res+=n&1;
                n>>=1;
            }
            return (int)res;
        }
    }
}