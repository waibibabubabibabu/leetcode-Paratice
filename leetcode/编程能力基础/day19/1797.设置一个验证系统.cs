
/*你需要设计一个包含验证码的验证系统。每一次验证中，用户会收到一个新的验证码，这个验证码在 currentTime 时刻之后 timeToLive 秒过期。
如果验证码被更新了，那么它会在 currentTime （可能与之前的 currentTime 不同）时刻延长 timeToLive 秒。

请你实现 AuthenticationManager 类：

AuthenticationManager(int timeToLive) 构造 AuthenticationManager 并设置 timeToLive 参数。
generate(string tokenId, int currentTime) 给定 tokenId ，在当前时间 currentTime 生成一个新的验证码。
renew(string tokenId, int currentTime) 将给定 tokenId 且 未过期 的验证码在 currentTime 时刻更新。如果给定 tokenId 对应的验证码不存在或已过期，
请你忽略该操作，不会有任何更新操作发生。

countUnexpiredTokens(int currentTime) 请返回在给定 currentTime 时刻，未过期 的验证码数目。
如果一个验证码在时刻 t 过期，且另一个操作恰好在时刻 t 发生（renew 或者 countUnexpiredTokens 操作），过期事件 优先于 其他操作。

来源：力扣（LeetCode）
链接：https://leetcode.cn/problems/design-authentication-manager
著作权归领扣网络所有。商业转载请联系官方授权，非商业转载请注明出处。*/
public class AuthenticationManager
{
    Dictionary<string, int> dictionary;
    int timeToLive;
    public AuthenticationManager(int timeToLive)
    {
        this.timeToLive = timeToLive;
        dictionary = new Dictionary<string, int>();
    }

    public void Generate(string tokenId, int currentTime)
    {
        dictionary.Add(tokenId, currentTime + timeToLive);
    }

    public void Renew(string tokenId, int currentTime)
    {
        if (dictionary.ContainsKey(tokenId) && currentTime > dictionary[tokenId]) //表示还没过期且存在
            dictionary[tokenId] = currentTime + timeToLive;
    }

    public int CountUnexpiredTokens(int currentTime)
    {
        int count = 0;
        foreach (var item in dictionary)
        {
            if (item.Value <= currentTime) count++;
            else dictionary.Remove(item.Key);//不浪费空间
        }
        return count;
    }
}

/**
 * Your AuthenticationManager object will be instantiated and called as such:
 * AuthenticationManager obj = new AuthenticationManager(timeToLive);
 * obj.Generate(tokenId,currentTime);
 * obj.Renew(tokenId,currentTime);
 * int param_3 = obj.CountUnexpiredTokens(currentTime);
 */