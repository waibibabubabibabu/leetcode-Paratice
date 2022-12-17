using System;
namespace LeeCode{
    class Solution3{    
        public int MaximumWealth(int[][] accounts) {
        int max=0;int i=0;
        
        while(i<accounts.Length)
        {
            int j=0,temp=0;
            while(j<accounts[0].Length)
            {
                temp+=accounts[i][j];
                j++;
            }
            i++;
            max=(temp>max?temp:max);
        }
        return max;

    }
}
}
