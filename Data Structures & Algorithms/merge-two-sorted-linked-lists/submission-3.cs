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
    public ListNode MergeTwoLists(ListNode list1, ListNode list2) {

        if(list1 == null && list2 == null){
            return null;
        }

        if(list1 == null){
            return list2;
        }

        if(list2 == null){
            return list1;
        }
        ListNode value = new ListNode(0);
        ListNode merged = value;

        while( list1 != null && list2 != null){
            if(list1.val < list2.val){
                merged.next = list1;
                list1 = list1.next ;
            }
            else{
                merged.next = list2;
                list2 = list2.next;
            }
            merged = merged.next;

        }

        if(list1 == null){
            merged.next = list2;
        }
        else{
            merged.next = list1;
        }

        return value.next;

        
    }
}