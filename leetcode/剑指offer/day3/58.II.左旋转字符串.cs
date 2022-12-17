using System.Text;
public class Solution {
    public string ReverseLeftWords(string s, int n) {
        return s.Substring(n)+s.Substring(0,n);
        StringBuilder newStr=new StringBuilder();
        newStr.Append(s.Substring(n));
        newStr.Append(s.Substring(0,n));
        return newStr.ToString();
    }
}