public class Solution {
    public int MajorityElement(int[] nums) {
        // Moore's Voting Algorithm
        int ME = nums[0];
        int count = 1;
        for(int i = 1; i < nums.Length; ++i){
            count = (ME == nums[i]) ? count+1 : count-1;
            if(count == 0){
                ME = nums[i];
                count = 1;
            }
        }
        
        return ME;
    }
}