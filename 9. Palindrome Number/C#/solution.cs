public class Solution {
    public bool IsPalindrome(int x) {
        // Negative numbers can never be palindromes.
        if(x < 0){
            return false;
        }
        // Rebuild number by appending each chopped off right digit to reverse.
        int reverse = 0;
        for(int number = x; number > 0; number /= 10){
            reverse = reverse * 10 + number % 10;
        }
        return x == reverse;
    }
}