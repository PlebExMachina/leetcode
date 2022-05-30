public class Solution {
    public string IntToRoman(int num) {
        // Longest roman numeral under constraints.
        var result = new List<char>(9);
        
        // Simply reduce based on most significant single/pair and construct left to right.
        // Subtract value to determine next symbols.
        while(num > 0){
            if(num >= 1000){
                num-= 1000;
                result.Add('M');
            } else if(num >= 900) { 
                num-= 900;
                result.Add('C');
                result.Add('M');
            } else if(num >= 500) {
                num-= 500;      
                result.Add('D');
            } else if(num >= 400) { 
                num-= 400;
                result.Add('C');
                result.Add('D');
            } else if(num >= 100) {
                num-=100;
                result.Add('C');
            } else if(num >= 90) {
                num-=90;
                result.Add('X');
                result.Add('C');
            } else if(num >= 50) {
                num-=50;
                result.Add('L');
            } else if(num >= 40) {
                num-=40;
                result.Add('X');
                result.Add('L');
            } else if(num >= 10) {
                num-=10;
                result.Add('X');
            } else if (num >= 9) {
                num-=9;
                result.Add('I');
                result.Add('X');
            } else if(num >= 5) {
                num-=5;
                result.Add('V');
            } else if(num >= 4) {
                num-=4;
                result.Add('I');
                result.Add('V');
            } else {
                num-=1;
                result.Add('I');
            }
        }
        return new string(result.ToArray());
    }
}