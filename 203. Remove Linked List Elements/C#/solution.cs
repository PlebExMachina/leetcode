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
    public ListNode RemoveElements(ListNode head, int val) {
        // Prune front until lead element is valid.
        while(head != null && head.val == val){
            head = head.next;
        }
        // Prune remaining elements.
        for(ListNode i = head; i != null; i = i.next){
            while((i.next != null) && (i.next.val == val)){
                i.next = i.next.next;
            }
        }
        return head;
    }
}