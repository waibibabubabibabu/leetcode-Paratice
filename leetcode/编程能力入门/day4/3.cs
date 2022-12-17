using System;
namespace Leecode{
    class Solution3{
        public bool IsHappy(int n) {
            
            int count=0;
            while(count<1000)
            {
                int temp=0;
                while(n!=0)
            {
                temp+=(n%10)*(n%10);
                n/=10;
            }
            if(temp==1) return true;
            n=temp;
            count++;
            }
           return false;
    }
    }
    class Solution31 {//快慢指针，利用开心数的性质
    public int getNext(int n) {
        int totalSum = 0;
        while (n > 0) {
            int d = n % 10;
            n = n / 10;
            totalSum += d * d;
        }
        return totalSum;
    }

    public bool IsHappy(int n) {
        int slowRunner = n;
        int fastRunner = getNext(n);
        while (fastRunner != 1 && slowRunner != fastRunner) {
            slowRunner = getNext(slowRunner);
            fastRunner = getNext(getNext(fastRunner));
        }
        return fastRunner == 1;
    }
}
}

