public class Solution {
    private static int SumOfDigits(int num){
        int output = 0;
        while(num != 0){
            output += num % 10;
            num /= 10;
        }
        return output;
    }
    
    public int AddDigits(int num) {
        while(num > 9){
            num = SumOfDigits(num);
        }
        return num;
    }
}