using System;
namespace LeeCode{
    class Solution2{
        public double Average(int[] salary) {
            double sum=0;int low=salary[0];int high=0;
            for(int i=0;i<salary.Length;i++)
            {
                sum+=salary[i];
                if(salary[i]<low)low=salary[i];
                if(salary[i]>high) high=salary[i];
            }
            sum-=(low+high);
            return sum/(salary.Length-2);
        }
    }
}