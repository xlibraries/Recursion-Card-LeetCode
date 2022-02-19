public class Solution 
{
    ListNode prevNode = null;
    public ListNode ReverseList(ListNode head) 
    {
        if(head == null)
        {
            return prevNode;
        }
        ListNode nextNode = head.next;
        head.next = prevNode;
        prevNode = head;
        head = nextNode;
        ReverseList(nextNode);
        return prevNode;
    }
}
