public class Solution {
       // Vishal's Solution
       //  https://leetcode.com/problems/reverse-bits/discuss/2189972/O(1)-solution-without-for-loop-using-follow-up-in-the-question-hint
    private static uint reverseBitsVishal(uint n){

        // Explanation-

        // When I saw this I bust out laughing for around a minute straight.
        // They swap the bits by partitions that step down by half each.
        
        // First the left 16 and the right 16 are isolated, then or'd (concatenating them) 
        // swapped.
        n = ((n & 0xffff0000) >> 16) | ((n & 0x0000ffff) << 16);
        
        // Next it's broken up into groups of 8 hence the ff00
        // So the halves are swapped in halves of halves
        n = ((n & 0xff00ff00) >> 8) | ((n & 0x00ff00ff) << 8);
        
        // And so on with groups of 4...
        n = ((n & 0xf0f0f0f0) >> 4) | ((n & 0x0f0f0f0f) << 4);
        
        // And so on with groups of 2...
        // C = 1100 in binary so it's 11001100... etc.
        n = ((n & 0xcccccccc) >> 2) | ((n & 0x33333333) << 2);
        
        // And so on with groups of 1.
        // A = 1010 in binary so it's 10101010... etc.
        n = ((n & 0xaaaaaaaa) >> 1) | ((n & 0x55555555) << 1);
        
        // I do document these in my own repository so I thought this was just too notable not to save.
        return n;
    }
    
    // Simple bruteforce solution.
    private static uint reverseBitsNaive(uint n){
        uint rev = 0;
        // For 32 Bits
        for(int i = 0; i < 32; ++i){
            // Shift output by 1 and store if rightmost bit of n is set.
            rev = rev << 1 | (n & 1);
            // Shift input by 1 to expose next bit.
            n >>= 1;
        }
        return rev;
    }
    
    public uint reverseBits(uint n) {
        return reverseBitsNaive(n);
    }
}

// It may be possible to use a memoization optimization by partitioning the bits...
// But there's no reason if you can just use a partitioning approach to reverse them outright like Vishal's method.