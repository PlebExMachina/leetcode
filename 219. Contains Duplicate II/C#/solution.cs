public class Solution {
    public bool ContainsNearbyDuplicate(int[] nums, int k) {
        var dict = new Dictionary<int,int>();
        for(int i = 0; i < nums.Length; ++i){
            if(dict.ContainsKey(nums[i])) { 
                // Test for distance.
                int j = dict[nums[i]];
                if(Math.Abs(i - j) <= k){
                    return true;
                }
            }
            // Track index of most recent element.
            dict[nums[i]] = i;
        }
        return false;
    }
}