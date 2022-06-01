public class Solution {
    public int RemoveDuplicates(int[] nums) {
        // Constraint: 1 <= nums.length <= 3 * 104
        // We can always start from second element onward.
        // Because it's already sorted nums[0] is in the correct order.
        int key = nums[0];
        int size = 1;
        for(int i = 1; i < nums.Length; ++i){
            if(nums[i] > key){
                key = nums[i]; 
                nums[size] = nums[i];
                ++size;
            }
        }
        return size;
    }
}

// ~O(N)