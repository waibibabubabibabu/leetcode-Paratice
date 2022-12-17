public class Solution1 {
    public int FindRepeatNumber(int[] nums) {
        //任意一个
        HashSet<int> hash=new HashSet<int>();
        foreach(int i in nums)
        {
            if(hash.Contains(i)==false)
            {
                hash.Add(i);
            }
            else{
                return i;
            }
        }
        return -1;
    }
}