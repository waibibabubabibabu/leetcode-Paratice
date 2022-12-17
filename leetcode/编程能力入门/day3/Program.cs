using System;
namespace Leecode{
    class program{
        /*static void Main(string[] args)
        {
            Solution1 s1=new Solution1();
            int []nums=new int[]{3,4,15,2,9,4};
            int res1=s1.LargestPerimeter(nums);
            Console.WriteLine(res1);
        }*/
        static void Main(string[] args)
        {
            Solution2 s2=new Solution2();
            int[][] points=new int[5][];
            for(int i=0;i<5;i++) points[i]=new int[2];
            int res2=s2.NearestValidPoint(3,4,points);
            Console.WriteLine(res2);
        }
    }
}