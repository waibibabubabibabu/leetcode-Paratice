public class Solution2 {
    public int LengthOfLastWord(string s) {//有手就行
        int index=s.Length-1;
        int len=0;
        while(true)
        {
            while(s[index]==' ') index--;
            while(index>=0&&s[index--]!=' ') len++;
            return len;
        }
    }
}