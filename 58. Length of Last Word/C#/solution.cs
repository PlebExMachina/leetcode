public class Solution {
    // Simply count each character and...
    // ... reset on the first new character if a space has been observed.
    public int LengthOfLastWord(string s) {
        int Length = 0;
        bool resetCounter = false;
        foreach(var c in s){
            if(c == ' ') { 
                resetCounter = true;
            } else {
                if(resetCounter){
                    Length = 0;
                    resetCounter = false;
                }
                ++Length;
            }
        }
        return Length;
    }
}