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
    public ListNode ReverseList(ListNode head) {
        
        if (head == null || head.next == null)
        {
            Console.WriteLine("List is empty or has only one node.");
            return head;
        }

        ListNode Node = null;
        ListNode Prev = null;

        while (head != null)
        {
            Node = new ListNode(head.val, Prev);
            head = head.next;
            Prev = Node;
        }

       

        return Prev;
    }
}
