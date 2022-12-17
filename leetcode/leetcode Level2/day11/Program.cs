class program
{
    static void Main()
    {
        int[][]routes=new int[2][];
        routes[0]=new int[]{1,2,7};
        routes[1]=new int[]{3,6,7};
        int source = 1, target = 6;
        Solution s=new Solution();
        s.NumBusesToDestination(routes,source,target);
    }
}