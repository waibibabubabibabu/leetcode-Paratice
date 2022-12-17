using System;
class Solution1{

     public int[] SortByBits(int[] arr) {
        if(arr==null||arr.Length<=0) return arr;
        Array.Sort(arr,(x,y)=>{
            var v1=BitCount(x);
            var v2=BitCount(y);
            return(v1==v2)? x.CompareTo(y):v1.CompareTo(v2);
        });
        return arr;
        
    }

    private int BitCount(int v){
        int res = 0;
        while (v > 0) {
            if ((v & 1) == 1) res++;
            v >>= 1;
        }
        return res;
    }
}