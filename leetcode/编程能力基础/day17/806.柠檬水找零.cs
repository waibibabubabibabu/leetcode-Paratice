public class Solution2
{
    public bool LemonadeChange(int[] bills)
    {
        int[] change = new int[3];//表示钞票的个数
        foreach (int i in bills)
        {
            if (i == 5) change[0]++;
            else if (i == 10)
            {
                if (change[0] == 0) return false;//找不开了
                else { change[1]++; change[0]--; }
            }
            else
            {//两种情况
                if (change[1]!=0)//小贪心，优先用10元的
                {
                    if(change[0]!=0)
                    {
                        change[1]--;change[0]--;
                        change[2]++;
                    }
                    else return false;
                }
                else if(change[0]<3) return false;
                else{
                    change[0]-=3;change[2]++;
                }

            }
        }
        return true;
    }
}