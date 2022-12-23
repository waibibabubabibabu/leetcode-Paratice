public class Solution1
{
    public int TranslateNum(int num)
    {
        //dp，公式是F（i）=F(i-1)+F(i-2)
        //不翻译就是F（i-1），翻译就是F（i-2）
        int a=1,b=1,x,y=num%10;
        while(num!=0)
        {
            num/=10;
            x=num%10;
            int tmp=x*10+y;
            int c=(tmp>=10&&tmp<=25)?a+b:a;
            b=a;
            a=c;
            y=x;
        }
        return a;
    }
    public int TranslateNum1(int num)
    {
        int count = 0;
        //统计不能重复出现的个数
        int count2 = 0;
        int tmp = 10;
        bool tmpIsUsed = false;
        do
        {
            tmp = num % 10;
            num /= 10;
            if (tmp + num % 10 * 10 <= 25)
            {
                count++;
                if (tmpIsUsed)
                    tmpIsUsed = !tmpIsUsed;
                else
                {
                    count2++;
                    tmpIsUsed = true;
                }
            }
        } while (num != 0);
        return count;//并不是简单的count累加，是前面结果的累计
    }
}