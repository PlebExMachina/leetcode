public class Solution {
    public int RemoveElement(int[] nums, int val) {
        int count = 0;
        for(int i = 0; i < nums.Length; ++i){
            // Push bad elements towards the front.
            for(int j = i; (j > 0) && (nums[j] != val) && (nums[j-1] == val); --j){
                int temp = nums[j];
                nums[j] = nums[j-1];
                nums[j-1] = temp;
                
                // When swapping back our current index is the last bad index so...
                // Sub Length - 1 (or just j) is our new count.
                count = j;
            }
            
            // If our current position (ahead of j cursor) is a valid item then should
            // consider the current length the actual count.
            if(nums[i] != val){
                count = i+1;
            }
        }
        return count;
    }
}

// My solution treats the problem as a special case of insertion sort.