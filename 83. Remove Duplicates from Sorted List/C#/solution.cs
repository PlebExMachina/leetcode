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
    public ListNode DeleteDuplicates(ListNode head) {
        // Start at head.
        ListNode itr = head;
        
        // While still iterating.
        while(itr != null){
            // Then see if the current node is a duplicate of the next.
            // Remove them accordingly.
            while((itr.next != null) && (itr.val == itr.next.val)){
                itr.next = itr.next.next;
            }   
            itr = itr.next;
        }
        return head;
    }
}