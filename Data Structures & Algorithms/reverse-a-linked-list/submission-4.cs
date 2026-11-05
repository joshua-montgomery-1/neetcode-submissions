
public class Solution
{
    public ListNode ReverseList(ListNode head)
    {
        return Reverse(head);
    }

    public ListNode Reverse(ListNode node)
    {
        if (node == null || node.next == null)
            return node;

        ListNode newHead = Reverse(node.next);

        node.next.next = node;
        node.next = null;

        return newHead;
    }
}
