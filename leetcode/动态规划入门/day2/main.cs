using System;
namespace Leecode{
    class progress{
        /*static void Main(string[] args)
        {
            Solution1 s1=new Solution1();
            int res1;
            res1=s1.ClimbStairs(44);
            Console.WriteLine(res1);
            Solution1Dot1 s1Dot1=new Solution1Dot1();
            int resDot1=s1Dot1.ClimbStairs(44);
            Console.WriteLine(resDot1);
        }*/
        static void Main(string[] args)
        {
            Solution2 s2=new Solution2();
            int []cost=new int[]{10,15,20};
            int res2=s2.MinCostClimbingStairs(cost);
            Console.WriteLine(res2);
        }
    }
}