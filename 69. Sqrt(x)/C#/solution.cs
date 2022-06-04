public class Solution {
    // Thank you leetcode for using a long as an input for an int function.
    public int MySqrt(int x) { 
        if(x == 0 || x == 1) {
            return x;
        }
        // Use binary search to approximate answer.
        long start = 0, end = x;
        long mid; 
        long ans = 0; 
        
        while(start <= end){ 
            mid = (start + end) / 2; 
            if(mid * mid == x) {      
                ans = mid;
                break;
            }
            
            if(mid * mid < x) {
                start = mid + 1;
                ans = mid;
            } else {
                end = mid - 1;
            }
        }
        
        return (int)ans;
    }
}