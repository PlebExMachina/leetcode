/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
public class Solution {
    private void DeleteNodeIterative(ListNode node){
        while(node != null){
            // Shift value left.
            node.val = node.next.val;
            
            // If tail chop last element off and finish.
            if(node.next.next == null){
                node.next = null;
                break;
            // Otherwise iterate to next element.
            } else {
                 node = node.next;   
            }
        }  
    }

    private void DeleteNodeRecursive(ListNode node){
        // If a valid node
        if(node != null) { 
            // Shift the value left.
            node.val = node.next.val;
            
            // If tail chop last element off.
            if(node.next.next == null){
                node.next = null;
            // Otherwise recurse to next element.
            } else {
                DeleteNodeRecursive(node.next);   
            }
        }
    }
    
    public void DeleteNode(ListNode node) {
       DeleteNodeIterative(node);
    }
}