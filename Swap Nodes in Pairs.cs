public class Solution 
{
    public ListNode SwapPairs(ListNode head) 
    {
        if(head == null || head.next == null)
        {
            return head;
        }
        Helper(head);
        return head;
    }
    public void Helper(ListNode head)
    {
        if(head == null || head.next == null)
        {
            return;
        }
        int temp = head.val;
        head.val = head.next.val;
        head.next.val = temp;
        head = head.next.next;
        Helper(head);
    }
}
