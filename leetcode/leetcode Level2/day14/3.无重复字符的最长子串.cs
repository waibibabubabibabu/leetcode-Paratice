public class Solution1 {
    public int LengthOfLongestSubstring(string s) {
        //身体，s中啥都有
        if(s==null) return 0;
        HashSet<char> hash=new HashSet<char>();
        int left=0,right=0;
        int max=0;
        foreach(char i in s)
        {
            while(hash.Contains(i))
            {
                hash.Remove(s[left]);
                left++;
            }
            hash.Add(i);
            right++;
            max=Math.Max(max,hash.Count);
        }
        return max;
    }
}