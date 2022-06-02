public class Solution {
    public int StrStr(string haystack, string needle) {
        // Empty string case.
        if("" == needle){
            return 0;
        }
        // Needle too big for haystack.
        if(needle.Length > haystack.Length){
            return -1;
        }
        
        // Otherwise only search the haystack if there's room for the needle.
        for(int i = 0; i <= haystack.Length - needle.Length; ++i){
            
            // Only check if it's potentially the start of a needle.
            if(needle[0] == haystack[i]){
                // Assume the needle is found.
                int iCursor = i+1;
                bool needleFound = true;
                for(int j = 1; j < needle.Length; ++j){
                    // If mistaken then ignore.
                    if(needle[j] != haystack[iCursor]){
                        needleFound = false;
                        break;
                    }
                    ++iCursor;
                }
                // Otherwise, yay! Needle!
                if(needleFound){
                    return i;
                }
            }            
        }
        
        return -1;
    }
}