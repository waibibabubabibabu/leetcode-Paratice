using System;
namespace LeeCode{
    class main{
    static void Main(string[] args){
        Solution2 S2=new Solution2();
        double res;
        int[] salary=new int[]{8000,9000,2000,3000,6000,1000};
        res=S2.Average(salary);
        Console.WriteLine(res);
    }
}
}
