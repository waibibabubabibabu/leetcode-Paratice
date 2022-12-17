public class Solution1 {
    public bool IsHappy(int n) {
        int count=0;
        while(count<=500)
        {
            int tmp=0;
            while(n!=0)
            {
                tmp+=(n%10)*(n%10);
                n/=10;
            }
            if(tmp==1) return true;
            else n=tmp;
            count++;
        }
        return false;
    }
    //count不能解决实际问题
    //可能出现三种情况：
    /*
    1.到1
    2.出现循环
    3.趋向于无限大

    */
    //3.999->next是243，四位数以上的数字会丢失1位跌回三位，详细看图片
    //需要判断是否进入循环，进入循环就可以判负了
    //转化为判断循环
}