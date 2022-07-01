public class Solution {
    // Loops occur on these numbers.
    private static bool WillLoop(int n){
        switch(n) {
            case 4:
            case 16:
            case 20:
            case 37:
            case 42:
            case 58:            
            case 89:
            case 145:
                return true;
                break;
            default:
                break;
        }
        return false;        
    }
    
    private static int SumOfSquares(int n){
        int output = 0;
        while(n != 0){
            int rightDigit = n % 10;
            output += rightDigit * rightDigit;
            n /= 10;
        }
        return output;
    }
    
    public bool IsHappy(int n) {
        while(n != 1){
            if(WillLoop(n)){
                return false;
            } else {
                 n = SumOfSquares(n);   
            }
        }
        return n == 1;
    }
}