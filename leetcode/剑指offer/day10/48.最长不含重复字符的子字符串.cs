public class Solution {
    public int LengthOfLongestSubstring(string s) {
        if(s==null) return 0;
        int left=0,right=0,max=0;
        HashSet<char> hash=new HashSet<char>();
        while(right<s.Length)
        {
            if(hash.Contains(s[right])==false)
            {
                hash.Add(s[right]);
            }
            else{
                max=Math.Max(max,right-left);
                while(left<=right&&s[left]!=s[right]) hash.Remove(s[left++]);
                left++;
            }
            right++;
        }
        max=Math.Max(max,right-left);
        return max;
        //return Math.Max(max,right-left);
    }
}