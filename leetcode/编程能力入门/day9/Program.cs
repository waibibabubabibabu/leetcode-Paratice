using System;
namespace LeeCode{
    class program{
        static void Main(string[] args)
        {
           Solution3 s3=new Solution3();
           string[] words=new string[]{"hello","leetcode"};
           string order="hlabcdefgijkmnopqrstuvwxyz";
           s3.IsAlienSorted(words,order);

        }
    }
}