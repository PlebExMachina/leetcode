public class Solution {
    private static int SumOfDigits(int num){
        int output = 0;
        while(num != 0){
            output += num % 10;
            num /= 10;
        }
        return output;
    }
    
    private static int SumOfDigitsIterative(int num){
        while(num > 9){
            num = SumOfDigits(num);
        }
        return num;
    }
    
    // Digital Root Formula
    private static int SumOfDigitsConstant(int num){
        return 1 + ( (num - 1) % 9 );
    }
    
    public int AddDigits(int num) {
        return SumOfDigitsConstant(num);
    }
}