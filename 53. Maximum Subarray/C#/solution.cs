public class Solution {
    public int MaxSubArray(int[] nums) {
        // Start with minimum possible maxSum.
        int sum = 0;
        int maxSum = Int32.MinValue;
        for(int i = 0; i < nums.Length; ++i){
            // Sum values.
            sum += nums[i];
            
            // If new max then track it.
            if(sum > maxSum){
                maxSum = sum;
            }
            
            // If sum ever dips below zero then running sum can only have negative value.
            // Therefore ignore it.
            if(sum < 0){
                sum = 0;
            }
        }
        return maxSum;
    }
}