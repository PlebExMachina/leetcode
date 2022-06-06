public class Solution {    
    private static int SafeGet(int[] arr, int i, int size){
        if(i < size){
            return arr[i];
        }
        return Int32.MaxValue;
    }
    
    private static void NMLogNM(int[] nums1, int m, int[] nums2, int n){
        // In-Place ~N(1) Space
        // ~O(N*Log(M+N)) solution is to merge nums and then sorting.
        // Even though the time complexity is worse than actual run time
        // should be similar because it is already sorted and partitioned
        // so quicksort is uniquely well suited to this problem.
        
        Array.Copy(nums2, 0, nums1, m, n);
        Array.Sort(nums1);        
    }
    
    private static void NM(int[] nums1, int m, int[] nums2, int n){
        // With ~O(M) Extra space ~O(M+N) is possible.
        // Taking advantage of numerical range constraint to make use of Int32.MaxValue

        var temp = new int[m];
        int tempSize = 0, nums2I = 0, tempI = 0;
        for(int i = 0; i < nums1.Length; ++i){
            // Safely get each number. 
            // Failure case is Int32.MaxValue so they wont be considered.
            int nums1Val = SafeGet(nums1, i, m);
            int tempVal  = SafeGet(temp, tempI, tempSize);
            int nums2Val = SafeGet(nums2, nums2I, n);
            
            // If a replacement needs to be made...
            if((nums1Val > tempVal) || (nums1Val > nums2Val)){
                // If we're still checking nums1 then store nums1 val in temp.
                if(i < m) { temp[tempSize++] = nums1[i]; }               
                // Nums2 is smallest
                if(nums2Val < tempVal){ nums1[i] = nums2[nums2I++]; }
                // Temp is smallest
                else { nums1[i] = temp[tempI++]; }
            }
        }        
    }
    public void Merge(int[] nums1, int m, int[] nums2, int n) {
        //NM(nums1, m, nums2, n);
        NMLogNM(nums1, m, nums2, n);
    }
}
