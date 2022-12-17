using System;
namespace Leecode{
    class Solution2{
        public int NearestValidPoint(int x, int y, int[][] points) {
            int minD=999;int minIndex=-1;
            for(int i=0;i<points.Length;i++)
            {
                if(x==points[i][0]||y==points[i][1])
                {
                    if(x==points[i][0]){
                        if(minD>Math.Abs(y-points[i][1])) minD=Math.Abs(y-points[i][1]);minIndex=i;
                }
                    else{
                        if(minD>Math.Abs(x-points[i][0])) minD=Math.Abs(x-points[i][0]);minIndex=i;
                }
                } 
            }
            return minIndex;
    }
    }
}
