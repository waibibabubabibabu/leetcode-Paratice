public class Solution
{
    public int Calculate(string s)
    {
        Stack<char> symbol = new Stack<char>();
        Stack<int> num = new Stack<int>();
        bool cal = false;
        bool isMinus = false;
        for (int i = 0; i < s.Length; i++)
        {
            if (s[i] != ' ')
            {
                if (isNumber(s[i]))
                {
                    int inum = s[i] - '0';
                    while (i < s.Length - 1 && (s[i + 1] == ' ' || isNumber(s[i + 1])))
                    {
                        if (isNumber(s[i + 1])) inum = inum * 10 + s[i + 1] - '0';
                        i++;
                    }
                    if (cal == false)
                    {
                        if (isMinus) inum *= -1;
                        num.Push(inum);
                    }
                    else
                    {
                        num.Push(caculation(symbol.Pop(), num.Pop(), inum));
                        cal = false;
                    }
                }
                else
                {
                    if (s[i] == '*' || s[i] == '/')
                    {
                        symbol.Push(s[i]);
                        cal = true;
                    }
                    else
                    {
                        if (s[i] == '-') isMinus = true;
                        else isMinus = false;
                        symbol.Push('+');
                    }

                }
            }
        }
        /*
        Stack<int> tmpstack=new Stack<int>();
        while(num.Count>0) tmpstack.Push(num.Pop());
        num=tmpstack;
        
        Stack<char> tmpstack1=new Stack<char>();
        while(symbol.Count>0) tmpstack1.Push(symbol.Pop());
        symbol=tmpstack1;
        */
        while (symbol.Count > 0)
        {
            int num1 = num.Pop();
            int num2 = num.Pop();
            int tmp = caculation(symbol.Pop(), num1, num2);
            num.Push(tmp);
        }
        return num.Pop();
    }
    public int caculation(char symbol, int num1, int num2)
    {
        if (symbol == '+') return num1 + num2;
        else if (symbol == '-') return num1 - num2;
        else if (symbol == '*') return num1 * num2;
        else return num1 / num2;
    }
    public bool isNumber(char i)
    {
        return '0' <= i && i <= '9';
    }
}