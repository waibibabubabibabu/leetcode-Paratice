public class Solution1 {
    HashSet<string> symbol =new HashSet<string>();//简化代码，略显多余
    public int EvalRPN(string[] tokens) {
        Stack<string> cal=new Stack<string>();
        
        symbol.Add("*");
        symbol.Add("/");
        symbol.Add("+");
        symbol.Add("-");
        foreach(string i in tokens)
        {
            if(symbol.Contains(i)==false) cal.Push(i); //是数字；
            else  cal.Push(Calculation(cal.Pop(),cal.Pop(),i)); //符号，并开始运算，将结果放入堆栈
        }
        return Convert.ToInt32(cal.Pop());
    }
    public string Calculation(string num1,string num2,string sym)//num1先出，是除数
    {
        int numa=0,numb=0;
        numa=Convert.ToInt32(num1);
        numb=Convert.ToInt32(num2);
        int res;
        if(sym.CompareTo("/")==0) res=numb/numa;
        else if(sym.CompareTo("*")==0) res=numb*numa;
        else if(sym.CompareTo("+")==0) res=numb+numa;
        else res=numb-numa;
        return res.ToString();
    }
}