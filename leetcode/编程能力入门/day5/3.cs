 using System;
namespace LeeCode{
    public class Solution3 {
 public bool CheckStraightLine(int[][] coordinates) {
    
    double k;
    if(coordinates[0][0]-coordinates[1][0]==0)
    {
        for(int i=1;i<coordinates.Length-1;i++)
        {
            if(coordinates[i+1]!=coordinates[i]) return false;
        }
        return true;
    }
    else k=(coordinates[0][1]-coordinates[1][1])/(coordinates[0][0]-coordinates[1][0]);//问题：不能转换成double型
    for(int i=1;i<coordinates.Length-1;i++)
    {
        if(coordinates[i][0]==coordinates[i+1][0]) return false;
        double newk=(coordinates[i][1]-coordinates[i+1][1])/(coordinates[i][0]-coordinates[i+1][0]);
        if(k!=newk) return false;
    }
    return true;
    }
    }
    }