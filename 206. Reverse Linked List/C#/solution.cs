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
    private static ListNode ReverseListIterative(ListNode head){
        // Push into FILO.
        var stack = new Stack<ListNode>();
        for(ListNode i = head; i != null; i = i.next){
            stack.Push(i);
        }
        
        // Make last element new head.
        stack.TryPeek(out head);
        
        // Append elements in reverse order.
        while(stack.Count > 0){
            ListNode curr = stack.Pop();
            ListNode next = null; stack.TryPeek(out next);
            curr.next = next;
        }
        
        return head;   
    }
    
    private static ListNode ReverseListRecursive(ListNode head){
        if(head == null || head.next == null){ return head; }
        ListNode last = ReverseListRecursive(head.next);
        head.next.next = head;
        head.next = null;
        return last;
    }
    
    public ListNode ReverseList(ListNode head) {
        return ReverseListIterative(head);   
    }
}