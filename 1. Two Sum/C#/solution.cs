public class Solution {
    private static readonly int[] NoResult = {};
    public int[] TwoSum(int[] nums, int target) {
        // Create Hash Table to push numbers to.
        // Numbers will be hashed in and their indices will be stored.
        // This creates a num -> index relationship.
        Dictionary<Int32, Int32> numsToIndices = new Dictionary<Int32, Int32>();
        
        /// ~O(N)
        for(Int32 i = 0; i < nums.Length; ++i){
            // Rearranging the function...
            //   nums[i] + nums[j] == target 
            //     to 
            //   target - nums[i] == nums[j] 
            //  nums[j] must be our compliment.
            Int32 compliment = target - nums[i];
            
            /// ~O(1)
            // If the compliment has already been found then return our indices.
            if(numsToIndices.ContainsKey(compliment)){
                return new int[2]{i,numsToIndices[compliment]};
            }
            // Otherwise remember this number for later 
            // as it may be another number's compliment.
            else {
                /// ~O(1)
                numsToIndices.TryAdd(nums[i],i);   
            }
            
        }
        // If no compliments found then there is no answer.
        return NoResult;      
    }
}