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
    // Extracts the nodes value if non-null, 0 otherwise.
    private static Func<ListNode,int> NodeVal = (x) => (x == null) ? 0 : x.val;

    // Iterates the node or does nothing if it's null.
    private static Func<ListNode,ListNode> IterateNode = (x) => (x == null) ? null : x.next;

    // Determines if there's any of either list that still needs iterating.
    private static Func<ListNode, ListNode, bool> ListRemains = (a,b) => (a != null) || (b != null);
    
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2) {
        // Head represents solutiion.
        ListNode head = null;
        ListNode tail = null;
        var carry = 0;
        
        /// ~O(Max(L1,L2))
        while(ListRemains(l1,l2)){
            // Value comes from potential node values and previous carry.
            var newNodeVal = NodeVal(l1)+NodeVal(l2)+carry;
            
            // Split result into single digit value and carry and then make new node.
            carry = newNodeVal / 10;
            newNodeVal %= 10;
            var newNode = new ListNode(newNodeVal);

            // If this is the first node then initalize head/tail
            if(head == null){ 
                head = newNode;
                tail = newNode;
            // Otherwise append to tail and set new tail.
            } else {
                tail.next = newNode;
                tail = IterateNode(tail);
            }
            // Advance iterators
            l1 = IterateNode(l1);
            l2 = IterateNode(l2);
        }

        // If any carry remains then append one last node.
        tail.next = (carry == 0) ? null : new ListNode(carry);

        return head;
    }
}