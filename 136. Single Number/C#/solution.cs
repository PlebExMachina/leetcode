public class Solution {
    // Use xor to perform pair annihilation. 
    public int SingleNumber(int[] nums) {
        int output = 0;
        foreach(var num in nums){
            output ^= num;
        }
        return output;
    }
}