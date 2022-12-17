public class Solution1
{
    public int[][] FloodFill(int[][] image, int sr, int sc, int color)
    {
        //考虑边界情况
        if(sr<0||sr>image.Length-1||sc<0||sc>image[0].Length-1) return image;
        //左边
        int temp=image[sr][sc];
        image[sr][sc]=color;
        //如果temp和color相等会陷入无限循环，让已经渲染过的不再渲染
        if (sc != 0 && image[sr][sc - 1] == temp&&image[sr][sc-1]!=color)  FloodFill(image, sr, sc - 1, color);
        //右边
        if (sc != image[0].Length - 1 && image[sr][sc + 1] == temp&&image[sr][sc+1]!=color)  FloodFill(image, sr, sc + 1, color);
        //上边
        if (sr != 0 && image[sr - 1][sc] == temp&&image[sr-1][sc]!=color)  FloodFill(image, sr - 1, sc, color);
        //下边
        if (sr != image.Length - 1 && image[sr + 1][sc] == temp&&image[sr+1][sc]!=color) FloodFill(image, sr + 1, sc, color);

        return image;
    }
    //递归太多了，导致溢出

}