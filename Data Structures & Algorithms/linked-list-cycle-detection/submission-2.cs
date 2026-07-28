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
    public bool HasCycle(ListNode head) {
       if(head == null || head.next == null)
       return false;
       ListNode head1 = head , head2 = head;
        while(head2.next != null && head2.next.next != null){

            head1 = head1.next;
            head2 = head2.next.next;
            if(head1.val == head2.val){
                return true;
            }

        }
        return false;
    }
}
