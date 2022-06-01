/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */
public class Solution {
    // Initializes lists if needed, otherwise appends and advances iterators.
   private static void MergeNode(ref ListNode output, ref ListNode outItr, ref ListNode list){
        if(output == null) {
            output = new ListNode(list.val);
            outItr = output;
        } else {
            outItr.next = new ListNode(list.val);
            outItr = outItr.next;
        }
        list = list.next;
    }
    
    public ListNode MergeTwoLists(ListNode list1, ListNode list2) {
        ListNode output = null;
        ListNode outItr = null;

        // Due to problem constraints nullness isn't too big of a deal.
        // MaxValue will exist outside of constraints and be able to represent
        // null nodes.
        Func<ListNode,int> NodeValue = (x) => x == null ? (Int32.MaxValue) : x.val;
        // This lets both comparisons be simple.
        while((list1 != null) || (list2 != null)){
            if((NodeValue(list2) < NodeValue(list1))) {
                MergeNode(ref output, ref outItr, ref list2);
            } else {
                MergeNode(ref output, ref outItr, ref list1);
            }
        }
        return output;
    }
}