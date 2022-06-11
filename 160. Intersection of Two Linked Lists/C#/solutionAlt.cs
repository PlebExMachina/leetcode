/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
public class Solution {
    // Appended Lists Approach. While obfuscated it is functionally identical to the
    // node count method (with slightly better memory usage.)
    // 
    // explanation...
    // in node count...
    //    A a1 -> a2 -> c1 -> c2 -> c3 [count = 5]
    //    B b1 -> b2 -> b3 -> c1 -> c2 -> c3 [count = 6]
    // 
    //    traverse longer (B) by difference |length a - length b|
    //    b1 -> b2
    //
    //    Then advance in parallel until intersection is found (reaching end means no intersection)
    //    b2 -> b3 ,  a1 -> a2
    //    b3 -> c1 ,  a2 -> c1 [Intersection Found]
    //
    // In Appended Lists Approach it takes advantage of
    // the fact that the ends of the lists look the same.
    // If you append the lists together they will also be the same length...
    // ... so if you iterate appended lists in parallel you will reach the intersection.
    //
    // A becomes A' a1 -> ... -> c3 -> b1 -> ... c3
    // B becomes B' b1 -> ... -> c3 -> a1 -> ... c3
    //
    // The length difference |length a - length b| becomes "how much sooner" the shorter list
    // enters the other list.
    //
    // So information is not lost, the data structure is exploited to achieve the same process.
    public ListNode GetIntersectionNode(ListNode headA, ListNode headB) {        
        ListNode itrA = headA, itrB = headB;
        while(itrA != itrB){
            itrA = (itrA == null) ? headB : itrA.next;
            itrB = (itrB == null) ? headA : itrB.next;
        }
        return itrA;
    }
}