public class Solution {
    private static int SumOfSquares(int n){
        int output = 0;
        while(n != 0){
            int rightDigit = n % 10;
            output += rightDigit * rightDigit;
            n /= 10;
        }
        return output;
    }

    // Cycle Finding Algorithm
    public bool IsHappy(int n) {
        int slow = n;
        int fast = SumOfSquares(n);
        while(fast != 1 && slow != fast){
            slow = SumOfSquares(slow);
            fast = SumOfSquares(SumOfSquares(fast));
        }
        return fast == 1;
    }
}