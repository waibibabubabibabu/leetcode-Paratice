using System;
public class Solution4 {
    public bool ContainsDuplicate(int[] nums) {
        HashSet<int> hash=new HashSet<int>();
        foreach(int i in nums){
            if(hash.Contains(i)==false) hash.Add(i);
            else return true;
        }
        return false;
    }
}