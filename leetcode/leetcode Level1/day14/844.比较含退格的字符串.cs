public class Solution1
{
    Stack<char> stacks;
    Stack<char> stackt;
    public bool BackspaceCompare(string s, string t)
    {
        stacks = new Stack<char>();
        stackt = new Stack<char>();
        for (int i = 0; i < s.Length; i++)
        {
            if (s[i] == '#') { if (stacks.Count != 0) stacks.Pop(); }
            else stacks.Push(s[i]);
        }
        for (int j = 0; j < t.Length; j++)
        {
            if (t[j] == '#') { if (stackt.Count != 0) stackt.Pop(); }
            else stackt.Push(t[j]);
        }
        if (stacks.Count != stackt.Count) return false;
        while (stacks.Count > 0 && stacks.Peek() == stackt.Peek()) { stacks.Pop(); stackt.Pop(); }
        if (stacks.Count == 0) return true;
        else return false;

    }
    public bool BackspaceCompare2(string s, string t)//想节省空空间，运用双指针
    {
        int sIndex = s.Length - 1, tIndex = t.Length - 1;
        int sSharp = 0, tSharp = 0;//统计当前#个数
        while (sIndex >= 0 && tIndex >= 0)
        {
            if (s[sIndex] == '#') { sIndex--; sSharp++; }//没办法应付相连的#
            else if (t[tIndex] == '#') { tIndex--; tSharp++; }
            else if (sSharp > 0) { sIndex--; sSharp--; }
            else if (tSharp > 0) { tIndex--; tSharp--; }
            else if (s[sIndex] == t[tIndex]) { sIndex--; tIndex--; }//定位到字符且sharp==0
            else return false;
        }
        if(sSharp>0||sIndex>=0&&s[sIndex] == '#')
        {
            while(sIndex>=0)
            {
                if (s[sIndex] == '#') { sIndex--; sSharp++; }
                else if (sSharp > 0) { sIndex--; sSharp--; }
                else break;
            }
        }
        if(tSharp>0||tIndex>=0&&t[tIndex] == '#')
        {
            while(tIndex>=0)
            {
                if (t[tIndex] == '#') { tIndex--; tSharp++; }
                else if (tSharp > 0) { tIndex--; tSharp--; }
                else break;
            }

        }
        if (sIndex==tIndex) return true;
        else return false;
    }
}