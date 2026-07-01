// Last updated: 7/2/2026, 2:49:43 AM
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
    public int GetDecimalValue(ListNode head) {
        int sum = 0;
        int counter = 0;
        ListNode current = head;
        while(current != null)
        {
            // 1. Shift the sum we have so far one place to the left
            // (which is the same as multiplying by 2)
             sum = sum * 2;

            // 2. Add the new bit (0 or 1) to the right-most position
            // This replaces your entire 'if' block
             sum = sum + current.val;
            
             current = current.next;
             // counter++; // We no longer need this counter
        }
        return sum;
    }
}