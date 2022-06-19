public class Solution {
    public bool IsPowerOfTwo(int n) {
        // Use classic "is power of two" formula. Guard against integer underflow.
        return (n != Int32.MinValue) && (n != 0) && ((n & (n - 1)) == 0);
    }
}