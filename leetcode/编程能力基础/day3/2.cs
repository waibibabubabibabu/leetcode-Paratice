public class Solution2 {
    public int[] PlusOne(int[] digits) {
        for(int i=digits.Length-1;i>=0;i--)
        {
            if(digits[i]<9){
                digits[i]++; return digits;
            }
            else{
                digits[i]=0;
            }
        }
        int []res=new int[digits.Length+1];
        res[0]=1;
        return res;    
    }
}