class program
{
    static void Main()
    {
        Solution s = new Solution();
        char[] tasks1 = new char[] { 'A', 'A', 'A', 'B', 'B', 'B', 'C', 'C', 'C' };
        char[] tasks2 = new char[] { 'A', 'A', 'A', 'A', 'A', 'A', 'B', 'B', 'B' };
        int n = 2;
        s.LeastIntervalcopy(tasks2, n);
    }
}