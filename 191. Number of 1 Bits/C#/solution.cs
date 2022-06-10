public class Solution {
    // Using Brian Kernighan’s Algorithm
    public int HammingWeight(uint n) {
        int count = 0;
        while(n > 0){
            n &= (n-1);
            ++count;
        }
        return count;
    }
}