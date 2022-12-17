using System.Runtime.InteropServices;
using System;
class program
{
    static void Main(string[] args)
    {
        Solution1 s = new Solution1();
        int[][] num = new int[2][];
        num[0]=new int[]{1,2};
        num[1]=new int[]{3,4};
        //num[2]=new int[]{13,3,6,7};
        //num[3]=new int[]{15,14,12,16};
        s.Rotate(num);
    }
}