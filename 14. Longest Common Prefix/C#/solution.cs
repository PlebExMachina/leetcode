public class Solution {
    public string LongestCommonPrefix(string[] strs) {
        // Edge case, if only one string then the whole string is the LCP.
        if(strs.Length == 1){
            return strs[0];
        }
        
        // Reserve space for 200 elements according to constraints.
        var output = new List<char>(200);
        
        // Loop will terminate once the end of any string is reached.
        int i = 0;
        while(true){
            // If end of first string then terminate.
            if(i >= strs[0].Length){
                return new string(output.ToArray());                
            }
            
            // Otherwise get test variable.
            char testChar = strs[0][i];    
            for(int j = 1; j < strs.Length; ++j){
                // If end of any string is reached OR test char doesn't match then terminate.
                if((i >= strs[j].Length) || ( testChar != strs[j][i])){
                    return new string(output.ToArray()); 
                }
            }
            
            output.Add(testChar);
            ++i;
        }
        
        // This should never execute.
        return "";
    }
}

// Constraint: 1 <= strs.length <= 200
// No need to check if array entries exist.

// Constraint: 0 <= strs[i].length <= 200
// Empty strings may exist.