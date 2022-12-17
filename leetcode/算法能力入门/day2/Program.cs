using System;
namespace Leecode{
    class program{
        /*static void Main(string[] args)
        {
            Solution1 s1=new Solution1();
            int []nums=new int[]{1,3,5,6};
            int target=2;
            int res1=s1.SearchInsert(nums,target);
            Console.WriteLine(res1);
        }*/
        static void Main(string[] args)
        {
            Solution2 s2=new Solution2();
            int[] nums=new int[]{-7,-3,2,3,11};
            nums=s2.SortedSquares(nums);
        }
    }
}