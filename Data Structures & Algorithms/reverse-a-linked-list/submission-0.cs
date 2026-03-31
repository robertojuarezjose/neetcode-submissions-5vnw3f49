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
            Console.WriteLine("-------------");
            Console.WriteLine("Current head value: " + head.val);
            Console.WriteLine("Prev is: " + (Prev == null ? "null" : Prev.val.ToString()));

            Node = new ListNode(head.val, Prev);

            Console.WriteLine("Created new node with value: " + Node.val);
            Console.WriteLine("Node.next is pointing to: " + (Node.next == null ? "null" : Node.next.val.ToString()));

            head = head.next;

            Console.WriteLine("Moved head forward.");
            Console.WriteLine("New head is: " + (head == null ? "null" : head.val.ToString()));

            Prev = Node;

            Console.WriteLine("Moved Prev forward.");
            Console.WriteLine("Prev is now: " + Prev.val);
        }

        Console.WriteLine("-------------");
        Console.WriteLine("Loop finished.");
        Console.WriteLine("Returning Prev, which is the head of the reversed list.");
        Console.WriteLine("Final Prev is: " + (Prev == null ? "null" : Prev.val.ToString()));

        return Prev;
    }
}
