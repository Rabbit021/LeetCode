namespace LeetCode.Top100
{
    public class Number21
    {
        public class ListNode
        {
            public int val;
            public ListNode next;
            public ListNode(int val = 0, ListNode next = null)
            {
                this.val = val;
                this.next = next;
            }
        }

        public ListNode MergeTwoLists(ListNode l1, ListNode l2)
        {
            while (l1 != null || l2 != null)
            {
                var d1 = l1?.val ?? 0;
                var d2 = l2?.val ?? 0;
                
                l1 = l1?.next;
                l2 = l2?.next;
            }
            return null;
        }
    }
}