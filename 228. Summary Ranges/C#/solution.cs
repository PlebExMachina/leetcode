public class Solution {
    public IList<string> SummaryRanges(int[] nums) {
        if(nums.Length == 0){
            return new string[0];
        } else {
            var output = new List<string>();
            int subRangeIndex = 0;   
            for(int i = 1; i <= nums.Length; ++i){
                if((i == nums.Length) || (nums[i]-1 != nums[i-1])){
                    if(subRangeIndex == i-1) { 
                        output.Add(String.Format("{0}", nums[subRangeIndex]));
                    } else {
                        output.Add(String.Format("{0}->{1}", nums[subRangeIndex], nums[i-1]));
                    }
                    subRangeIndex = i;
                }
            }
            return output;
        }
    }
}