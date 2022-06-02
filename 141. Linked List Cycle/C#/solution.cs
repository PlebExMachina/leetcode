/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) {
 *         val = x;
 *         next = null;
 *     }
 * }
 */
public class Solution {
    private static void AdvanceNode(ref ListNode l){
        if(l != null){
            l = l.next;
        }
    }
    public bool HasCycle(ListNode head) {
        // Singleton Case / Null List Case
        if((head == null) || (head.next == null)){
            return false;
        }
        
        // General Case
        // One iterator moves at a slow speed.
        // One iterator moves at double speed.
        // If cycle exists then the fast one will catch up.
        // Otherwise the fast one will become null very quickly.
        ListNode Slow = head;
        ListNode Fast = head;
        while(Fast != null){
            AdvanceNode(ref Slow);
            AdvanceNode(ref Fast);
            AdvanceNode(ref Fast);
            if(Slow == Fast){
                return true;
            }
        }
        return false;
    }
}