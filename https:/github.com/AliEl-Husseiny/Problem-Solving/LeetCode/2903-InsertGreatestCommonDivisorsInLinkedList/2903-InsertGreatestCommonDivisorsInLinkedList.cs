// Last updated: 7/2/2026, 2:48:05 AM
public class Solution {
    public ListNode InsertGreatestCommonDivisors(ListNode head) {
        if (head == null || head.next == null) {
            return head;
        }

        ListNode current = head;

        while (current.next != null) {
            ListNode first = current;
            ListNode second = current.next;

            int gcdValue = GetGreatestCommonDivisor(first.val, second.val);

            ListNode newNode = new ListNode(gcdValue, second);
            first.next = newNode;

            current = second;
        }

        return head;
    }

    private int GetGreatestCommonDivisor(int a, int b) {
        while (b != 0) {
            int temp = b;
            b = a % b;
            a = temp;
        }
        return a;
    }
}