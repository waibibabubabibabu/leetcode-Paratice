using System;
class Solution1{
     public int CountOdds(int low, int high) {
        int odd=0;
        if(low%2!=0)odd++;
        if(high%2!=0)odd++;
        if(odd==0||odd==1)odd+=(high-low)/2;
        else odd+=(high-low)/2-1;
        return odd;
    }
}