public class Solution {
    public bool IsPowerOfThree(int n) {
        // 1162261467 is largest power of 3 represented in 32 bit integers.
        // Any number that isn't a power of 3 will produce a non-zero remainder.
        return n <= 0 ? false : 1162261467 % n == 0;
    }
}