public class Solution//第一个难题做出来了，开心！
{
    public string MinWindow(string s, string t)
    {
        Dictionary<char, int> dic = new Dictionary<char, int>();
        foreach (char i in t)
        {
            if (dic.ContainsKey(i)) dic[i]++;
            else dic.Add(i, 1);
        }
        int left = 0, right = 0;
        int minlength = int.MaxValue;
        string ans = "";
        for (int i = 0; i < s.Length; i++)
        {
            if (dic.ContainsKey(s[i]))
            {
                dic[s[i]]--;
                right = i;
            }
            if (!dic.Values.Any(a => a > 0))
            {
                while (dic.Values.All(a => a <= 0))
                {
                    if (dic.ContainsKey(s[left]))
                        dic[s[left]]++;
                    left++;
                }
                if (right - left + 2 < minlength)
                {
                    minlength = right - left + 2;
                    ans = s.Substring(left - 1, minlength);
                }
            }
        }
        return ans;
    }
}