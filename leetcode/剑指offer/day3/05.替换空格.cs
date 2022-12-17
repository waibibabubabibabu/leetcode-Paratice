using System.Text;
public class Solution1 {
    public string ReplaceSpace(string s) {
        StringBuilder newS=new StringBuilder();
        foreach(char i in s)
        {
            if(i==' ') newS.Append("%20");
            else newS.Append(i);
        }
        return newS.ToString();
    }
}