
public class Solution1 {
    public int[] NextGreaterElements(int[] nums) {
        Stack<int> monotonicStack=new Stack<int>();
        int []res=new int[nums.Length];
        int index=0;
        while(index<nums.Length-1)
        {
            if(nums[index]>=nums[index+1])monotonicStack.Push(index);
            else{
                res[index]=nums[index+1];
                while(monotonicStack.Count>0&&nums[index+1]>nums[monotonicStack.Peek()])
                {
                    int temp=monotonicStack.Pop();
                    res[temp]=nums[index+1];
                }
            }
            index++;
        }
        monotonicStack.Push(index);
        index=0;
        while(index<nums.Length)
        {
            while(monotonicStack.Count>0&&nums[monotonicStack.Peek()]<nums[index])
            {
                res[monotonicStack.Pop()]=nums[index];
            }
            index++;
        }
        while(monotonicStack.Count>0) res[monotonicStack.Pop()]=-1;
        return res;
    }
}