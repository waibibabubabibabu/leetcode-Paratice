public class Solution1
{
    public int[] AsteroidCollision(int[] asteroids)
    {
        Stack<int> stack = new Stack<int>();
        foreach (int aster in asteroids)
        {
            bool alive = true;
            while (alive && aster < 0 && stack.Count > 0 && stack.Peek() > 0)
            {
                alive = stack.Peek() + aster < 0; // aster 是否存在
                if (stack.Peek()+aster <=0 )
                {  // 栈顶行星爆炸
                    stack.Pop();
                }
            }
            if (alive)
            {
                stack.Push(aster);
            }
        }
        int[] ans = stack.ToArray();
        Array.Reverse(ans);
        return ans;
    }
    /*
    作者：LeetCode-Solution
    链接：https://leetcode.cn/problems/asteroid-collision/solution/xing-xing-peng-zhuang-by-leetcode-soluti-u3k0/
    来源：力扣（LeetCode）
    著作权归作者所有。商业转载请联系作者获得授权，非商业转载请注明出处。*/
    public int[] AsteroidCollision1(int[] asteroids)
    {
        Stack<int> stack = new Stack<int>();
        foreach (int i in asteroids)
        {
            if (stack.Count == 0 || !(stack.Peek() > 0 && i < 0))
            {
                stack.Push(i);
            }
            else
            {
                while (stack.Count > 0 && stack.Peek() > 0 && i + stack.Peek() <= 0)
                {
                    //相撞
                    int tmp = stack.Pop();
                    if (tmp + i == 0) break;
                }
                if (stack.Count == 0 || stack.Peek() + i < 0) stack.Push(i);
            }
        }
        int[] ans = stack.ToArray();
        Array.Reverse(ans);
        return ans;
    }
}