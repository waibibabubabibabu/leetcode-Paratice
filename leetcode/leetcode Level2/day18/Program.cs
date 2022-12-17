class program{
    public static void Main()
    {
        Solution s=new Solution();
        string str="3+2*2-5*10/2+100";

        /*
        "3+2*2-5*10/2+100"
" 3/2 "
" 3+5 / 2 "
        */
        s.Calculate(str);
    }
}