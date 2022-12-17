using System;
namespace Leecode{
    class Solution2{
           public string Interpret(string command) {
            List<char> res=new List<char>();
            for(int i=0;i<command.Length;i++)
            {
                if(command[i]=='G') res.Add('G');
                else{
                    if(command[i]=='(')
                    {
                        if(command[i+1]==')')
                        { 
                            i++;
                            res.Add('o');//()
                        }
                        else {
                            while(command[i]!=')') i++;
                            res.Add('a');res.Add('l');
                        }
                    }
                }
            }
            return string.Join("",res);
    }
    public string solution(string command)
    {
        command=command.Replace("()","o");
        command=command.Replace("(","");
        command=command.Replace(")","");
        return command;
    }
}
}