/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
public class Solution {
    private static int GetLength(ListNode head){
        int length = 0;
        while(head != null){
            head = head.next;
            ++length;
        }
        return length;
    }
    
    private static void Traverse(ref ListNode itr, int count){
        while(count > 0){
            itr = itr.next;
            --count;
        }
    }
    
    public ListNode GetIntersectionNode(ListNode headA, ListNode headB) {        
        // Get length of each list.
        int lengthA = GetLength(headA), lengthB = GetLength(headB);
        
        // Traverse longer list to intersection point.
        ListNode itrA = headA, itrB = headB;
        if(lengthA > lengthB) { 
            Traverse(ref itrA,Math.Abs(lengthA - lengthB));
        } else if(lengthB > lengthA) {
            Traverse(ref itrB,Math.Abs(lengthA - lengthB));
        }
        
        // Each list has same number of nodes remaining. Advance one by one 
        // until intersection is found.
        while(itrA != itrB){
            itrA = itrA.next;
            itrB = itrB.next;
        }
        // Return intersection (or lack of);
        return itrA;
    }
}