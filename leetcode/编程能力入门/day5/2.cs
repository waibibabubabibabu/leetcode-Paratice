using System;
namespace LeeCode{
    public class Solution2 {
    public int[] NextGreaterElement(int[] nums1, int[] nums2) {
       List<int> res=new List<int>();
       Dictionary<int,int> Copynums2=new Dictionary<int, int>();
       int index=0;
        foreach(int i in nums2) Copynums2.Add(nums2[index],index++);
        for(int i=0;i<nums1.Length;i++)
        {
            index=Copynums2[nums1[i]];
            while(index<nums2.Length)
            {
                if(nums2[index]>nums1[i]){ 
                    res.Add(nums2[index]);
                    break;
                }
                index++;
            }
            if(index==nums2.Length) res.Add(-1);
        }
        return res.ToArray();
    }
    public class Solution21 {//单调栈和Hash表和Dictionary
    public int[] NextGreaterElement(int[] nums1, int[] nums2) {
        Dictionary<int, int> dictionary = new Dictionary<int, int>();
        Stack<int> stack = new Stack<int>();
        for (int i = nums2.Length - 1; i >= 0; --i) {
            int num = nums2[i];
            while (stack.Count > 0 && num >= stack.Peek()) {
                stack.Pop();
            }
            dictionary.Add(num, stack.Count > 0 ? stack.Peek() : -1);
            stack.Push(num);
        }
        int[] res = new int[nums1.Length];
        for (int i = 0; i < nums1.Length; ++i) {
            res[i] = dictionary[nums1[i]];
        }
        return res;
    }
}
}
}