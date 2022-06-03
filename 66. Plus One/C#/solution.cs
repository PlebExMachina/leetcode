public class Solution {
    public int[] PlusOne(int[] digits) {
        // Add from LSD to MSD propagating carry if needed.
        bool carry = true;
        for(int i = digits.Length - 1; (i >= 0) && carry; --i){
            if(digits[i] == 9) {
                digits[i] = 0;   
            } else {
                digits[i] += 1;
                carry = false;
            }
        }
        
        // If carry remains then a new MSD needs to be made.
        if(carry){
            int[] temp = digits;
            digits = new int[digits.Length + 1];
            digits[0] = 1;
            temp.CopyTo(digits, 1);
        }
        
        return digits;
    }
}