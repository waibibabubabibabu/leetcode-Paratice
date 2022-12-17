public class Trie
{
    public Trie[] next;//实现跳转
    public bool end;//作为单词的末端
    public Trie()
    {
        next = new Trie[26];
    }

    public void Insert(string word)
    {
        Trie curr=this;
        foreach (char i in word)
        {
            if (curr.next[i - 'a'] == null)
                curr.next[i - 'a'] = new Trie();
            curr=curr.next[i-'a'];
        }
        curr.end=true;

    }

    public bool Search(string word)
    {
        Trie curr=this;
        foreach(char i in word)
        {
            if(curr==null) return false;
            else curr=curr.next[i-'a'];
        }
        if(curr!=null&&curr.end) return true;
        else return false;
        
    }

    public bool StartsWith(string prefix)
    {
        Trie curr=this;
        foreach(char i in prefix)
        {
            if(curr==null) return false;
            else curr=curr.next[i-'a'];
            if(curr==null) return false;
        }
        return true;
    }
}

/**
 * Your Trie object will be instantiated and called as such:
 * Trie obj = new Trie();
 * obj.Insert(word);
 * bool param_2 = obj.Search(word);
 * bool param_3 = obj.StartsWith(prefix);
 */