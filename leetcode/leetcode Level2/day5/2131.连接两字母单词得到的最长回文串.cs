using System.Text;
public class Solution1
{
    //代码实现时，我们可以用一个26×26 的二维数组来统计各个字符串的出现次数，从而优化代码运行时间。
    public int LongestPalindrome(string[] words)
    {
        int ans = 0, flag = 0;
        Dictionary<string, int> dictionary = new Dictionary<string, int>();
        //两个字母分两种情况：
        foreach (string i in words)
        {
            if (i[0]==i[1]&&dictionary.ContainsKey(i)==false) dictionary.Add(i,1);
            else
            {
                string tmp = i.Substring(1,1)+i.Substring(0,1);
                if (dictionary.ContainsKey(tmp))
                {
                    dictionary[tmp]--;
                    if(dictionary[tmp]==0) dictionary.Remove(tmp);
                    ans += 4;
                }
                else if (dictionary.ContainsKey(i) == false) dictionary.Add(i, 1);
                else dictionary[i]++;
            }
        }
        foreach(KeyValuePair<string,int> kvp in dictionary) if(kvp.Key[0]==kvp.Key[1]) {ans+=2;break;}
        return ans;
    }
}