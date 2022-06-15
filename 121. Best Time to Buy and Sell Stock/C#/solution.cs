public class Solution {
    public int MaxProfit(int[] prices) {
        // Begin at zero profit, no low value found.
        int profit = 0;
        int low = Int32.MaxValue;
        foreach(var price in prices){
            // If we found a new lowest price then note it down.
            if(price < low){
                low = price;
            }
            
            // Compare against current price, if higher profit then note it down.
            if(price - low > profit){
                profit = price - low;
            }
        }
        return profit;
    }
}