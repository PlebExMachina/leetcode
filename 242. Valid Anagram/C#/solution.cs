public class Solution {
    public bool IsAnagram(string s, string t) {
        if(s.Length != t.Length){
            return false;
        }
        // xor pair elimination + value mult
        // This solution exploits several math properties.        
        // xor will become zero so long as compliments exist.
        // However compliments can be contained in strings alone.
        // Multiplying the values will cause the differences to run away from eachother however 
        // multiplication is still commutative meaning that it'll converge if the strings are 
        // identical.
        
        // I wanted to try something usual since partially anagrams can be treated as a pair annilhation problem.
        uint x = 0, sMult = 1, tMult = 1;
        for(int i = 0; i < s.Length; ++i){
            x = x ^ s[i] ^ t[i];
            sMult *= s[i];
            tMult *= t[i];
        }
        return x == 0 && sMult == tMult;
    }
}