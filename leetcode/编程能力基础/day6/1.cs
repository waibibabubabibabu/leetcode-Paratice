public class Solution1
{
    public int[] DailyTemperatures1(int[] temperatures)
    {//最简单的n……2遍历
        int[] res = new int[temperatures.Length];
        for (int i = 0; i < temperatures.Length; i++)
        {
            for (int j = i + 1; j < temperatures.Length; j++)
            {
                if (temperatures[j] > temperatures[i]) { res[i] = j - i; break; }
                if (j == temperatures.Length - 1) res[i] = 0;
            }
        }
        return res;//超出时间限制，出错
    }
    public int[] DailyTemperatures2(int[] temperatures)
    {//考虑res本身的性质
        int len = temperatures.Length;
        int[] res = new int[len];
        res[len - 1] = 0;
        for (int i = 0; i < len; i++)//出现连续下降或者不变，将该片段截取，统一处理
        {
            if (temperatures[i + 1] > temperatures[i]) res[i] = 1;
            else
            {
                int flag = i;
                while (temperatures[i + 1] <= temperatures[i])
                {
                    i++;
                }//i处等于1，出现回升，进一步处理，具体的方法未知
                while (flag < i) { res[flag] = i - flag; flag++; }
            }
        }
        return res;
    }
    struct Temperatures
    {//是否可以通过直接存坐标实现
        public int val;
        public int index;
    }
    public int[] DailyTemperatures3(int[] temperatures)
    {//参考堆栈，也是官方的解法
        int len = temperatures.Length;
        int[] res = new int[len];
        Stack<int> temperStack = new Stack<int>();
        for (int i = 0; i < len; i++)
            res[len - 1] = 0;//避免for溢出
        for (int i = 0; i < len - 1; i++)
        {
            if (temperatures[i + 1] > temperatures[i])
            {
                res[i] = 1;//还需要管前面的
                while (temperStack.Count!=0&&temperatures[i + 1] > temperatures[temperStack.Peek()])
                {
                    int index = temperStack.Pop();
                    res[index] = i + 1 - index;
                }

            }
            else
            {
                temperStack.Push(i);
            }
        }
        return res;
    }

}