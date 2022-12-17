public class Solution {
    public char FirstUniqChar(string s) {
        //不使用int，而使用bool，加入时bool取值是！containskey
        Dictionary<char,int> dictionary=new  Dictionary<char, int>();
        foreach(char i in s)
        {
            if(dictionary.ContainsKey(i)==false) dictionary.Add(i,1);
            else dictionary[i]++;
        }
        foreach(var kvp in dictionary)
        {
            if(kvp.Value==1) return kvp.Key;
        }
        return ' ';
    }
}