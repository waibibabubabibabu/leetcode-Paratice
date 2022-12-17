using System;
namespace LeeCode{
    class program{
        static void Main(string[] args)
        {
           Solution3 s3=new Solution3();
           int [][]coordinates=new int[5][];
           coordinates[0]=new int[]{-4,-3};
           coordinates[1]=new int[]{1,0};
           coordinates[2]=new int[]{3,-1};
           coordinates[3]=new int[]{0,-1};
           coordinates[4]=new int[]{-5,2};
           bool res3=s3.CheckStraightLine(coordinates);


        }
    }
}