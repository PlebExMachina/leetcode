public class Solution {
    public bool ContainsDuplicate(int[] nums) {
        // Associative Set
        var set = new HashSet<int>();
        foreach(int num in nums){
            // If not unique then duplicates exist.
            if(set.Contains(num)){
                return true;
            // Otherwise track (assumed) unique member.
            } else {
                set.Add(num);
            }
        }
        // All members were unique.
        return false;
    }
}