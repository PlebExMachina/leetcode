public class Solution {
    private class LongSubstringCounter {
        private BitArray charMap;
        public Int32 count { get; set; }
        
    public LongSubstringCounter() {
            count = 0;
            charMap = new BitArray(255, false);
    }
	
        
    public void set(char c, bool f){
                // (f ^ charMap[c])
                // Compare with existing entry to see if a change occured.
                // No change and the expression reduces to zero. Otherwise 1...
                // 
                // (1 - 2*!f)
                // if the change is positive then x1 (+1)
                // otherwise reduce by two so change is x-2 (-1)
                Int32 fInt = Convert.ToInt32(f);
                Int32 notfInt = Convert.ToInt32(!f);
                Int32 charMapInt = Convert.ToInt32(charMap[c]); 
				count += (fInt ^ charMapInt)*(1 - 2*notfInt);
            
                // Set Entry
				charMap[c] = f;
    }
    
    public bool isSet(char c) {
            return charMap[c];
        }
};
    
    public int LengthOfLongestSubstring(string s) {
        var counter = new LongSubstringCounter();
        Int32 count = 0;
        
        // Initialize a cursor. Iterator through the entire string...
        int cursor = 0;
        for(int i = 0; i < s.Length; ++i){
            // Upon finding a duplicate character increment cursor until we pass what we are 
            // replacing.
            // Remove old characters from the active substring as we increment past.
            if(counter.isSet(s[i])){
                while(cursor < s.Length){
                    ++cursor;
                    
                    // Remove old character from substring.
                    counter.set(s[cursor-1],false);
    
                    // If we have passed the old (duplicate) character then terminate.
                    if(s[cursor-1] == s[i]){ break; }
                }
            }
            // Tail element must always be in substring.
            counter.set(s[i],true);
            
			/** 
				Optimization Invariant: count can only ever increase by one. 
				Should avoid jump as well but I'm really stretching at this point,
				this saves a few cycles? 
			**/
            // update count to highest running count.
            if(count < counter.count){
                ++count;
            }
        }
        
        return count;
    }
}

// My solution uses two iterators to count up the substrings.
// The counter above tracks / untracks characters as they are part of the substring.
// This allows the answer to be determined in a single pass. ~O(N)
