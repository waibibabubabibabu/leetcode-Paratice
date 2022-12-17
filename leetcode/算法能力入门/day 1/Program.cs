using System;
namespace Leecode{
    class program{
        static void Main(string[] args)
        {
            Solution2 s2=new Solution2();
            VersionControl v=new VersionControl();

            int res=s2.FirstBadVersion(2126753390);
            v.setBad(1702766719);
            Console.WriteLine(res);
        }
    }
}