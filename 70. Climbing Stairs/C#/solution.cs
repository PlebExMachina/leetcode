public class Solution {
    public readonly double GoldenRatio = ((1 + Math.Sqrt(5)) / 2);
    public readonly double redGoldenRatio = 1 - ((1 + Math.Sqrt(5)) / 2);
    public readonly double sqrt5 = Math.Sqrt(5);
    public int ClimbStairs(int n) {
        return Convert.ToInt32(
                (Math.Pow(GoldenRatio,n+1) - Math.Pow(redGoldenRatio,n+1)) / sqrt5
        );
    }
}