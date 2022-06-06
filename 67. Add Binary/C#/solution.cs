public class Solution {
    // Converts the char value to an integral or 0 if not applicable.
    private int SafeGet(ref string str, int i) {
        if(i >= 0){
            return (str[i] == '1') ? 1 : 0;
        }
        return 0;
    }
    public string AddBinary(string a, string b) {
        // Maximum size should account for carry.
        var output = new char[Math.Max(a.Length, b.Length)+1];
        output[0] = '0';

        // Reverse iterate...
        int aItr = a.Length-1, bItr = b.Length-1;
        bool carry = false;
        for(int i = output.Length - 1; i >= 0; --i){
            // Add together values...
            int result = Convert.ToInt32(carry)+SafeGet(ref a, aItr--)+SafeGet(ref b, bItr--);
            carry = (result >= 2);
            output[i] = (result % 2 == 1) ? '1' : '0';
        }
        
        // If there is no carry then chop off first character.
        string outputString = new string(output);
        return (outputString[0] == '0') ? outputString.Substring(1) : outputString;
    }
}