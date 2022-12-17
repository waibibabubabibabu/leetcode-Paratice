public class Solution
{
    public string GetHint(string secret, string guess)//直接同步操作即可，用你吗的hash表
    {
        /*Dictionary<char, int> dictionary = new Dictionary<char, int>();
        for (int i = 0; i < secret.Length; i++) dictionary.Add(secret[i], i);
        int bulls = 0, cows = 0;
        for (int i = 0; i < guess.Length; i++)
        {
            if (dictionary.ContainsKey(guess[i]))
            {
                if(dictionary[guess[i]]==i) bulls++;
                else cows++;
            }
        }
        string ans=bulls.ToString()+"A"+cows.ToString()+"B";
        return ans;*/
        //题目如果是字符串仅由数字构成
        HashSet<int>[] hash = new HashSet<int>[10];//10张hash表
        for(int i=0;i<10;i++)  hash[i]=new HashSet<int>();
        for (int i = 0; i < secret.Length; i++) hash[secret[i] - '0'].Add(i);
        int bulls = 0, cows = 0;
        int []tmpcount=new int[10];
        for (int i = 0; i < guess.Length; i++)
        {
            if (hash[guess[i] - '0'].Count != 0)
            {
                if (hash[guess[i] - '0'].Contains(i)) bulls++;
                else if(tmpcount[guess[i]-'0']<=hash[guess[i] - '0'].Count)
                {
                    cows++;
                }
                tmpcount[guess[i]-'0']++;
                /*if(hash[guess[i] - '0'].Contains(-1)==false)
                {
                    cows++;//如何防止重复加减，而是有多少count算多少奶牛，不能超过原有的secret的个数
                    hash[guess[i] - '0'].Add(-1);//加入标识符
                }*/
                
            }
        }
        string ans = bulls.ToString() + "A" + cows.ToString() + "B";
        return ans;
    }
    
}
public class Solutioncopy {
    public string GetHint(string secret, string guess) {
        int bulls = 0;
        int[] cntS = new int[10];
        int[] cntG = new int[10];
        for (int i = 0; i < secret.Length; ++i) {
            if (secret[i] == guess[i]) {
                ++bulls;
            } else {
                ++cntS[secret[i] - '0'];
                ++cntG[guess[i] - '0'];
            }
        }
        int cows = 0;
        for (int i = 0; i < 10; ++i) {
            cows += Math.Min(cntS[i], cntG[i]);
        }
        return bulls.ToString() + "A" + cows.ToString() + "B";
    }
}
