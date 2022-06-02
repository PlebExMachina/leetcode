public class Solution {
    // Question is begging for Binary Search
    public int SearchInsert(int[] nums, int target) {        
        // Works, Manual Implementation
        /*
        int high = nums.Length;
        int low = 0;
        int mid = -1;
        while(low < high){
            mid = (low + high)/2;
            if(nums[mid] == target){
                return mid;
            } else if(target < nums[mid]){
                high = mid;
            } else if(target > nums[mid]){
                low = mid + 1;
            }
        }
        return (target < nums[mid]) ? mid : mid + 1;
        */
        
        // C# Native BinarySearch
        int index = Array.BinarySearch(nums,target);
        return (index < 0) ? ~index : index;
    }
}