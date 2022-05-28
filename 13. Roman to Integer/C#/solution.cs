public class Solution {
    private int ctoi(char c){
        // Directly map numerals to int.
        switch(c){
            case 'I': return 1;
            case 'V': return 5;
            case 'X': return 10;
            case 'L': return 50;
            case 'C': return 100;
            case 'D': return 500;
            case 'M': return 1000;
        }
        return 0;
    }
    
    public int RomanToInt(string s) {
        int prev = 0;
        int finalValue = 0;
        foreach(var numeral in s){
            // Add numerals together..
            int curr = ctoi(numeral);
            finalValue += curr;
            
            // If subtraction rule occured then subtract (also remove previous addition)
            if(curr > prev){
                finalValue -= 2 * prev;
            }
            
            prev = curr;
        }
        return finalValue;
    }
}