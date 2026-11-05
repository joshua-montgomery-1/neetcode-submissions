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

        HashSet<ListNode> visited = new HashSet<ListNode>();

        var current = head;

        while(current?.next != null)
        {
            if(visited.Contains(current.next))
                return true;
            
            visited.Add(current.next);
            current = current.next;
        }

        return false;
    }
}
