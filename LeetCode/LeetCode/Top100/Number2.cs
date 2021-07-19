using LeetCode.TowSum;

namespace LeetCode.Top100
{
    /// <summary>
    /// https://leetcode-cn.com/problems/add-two-numbers/
    /// </summary>
    public class Number2
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

        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            ListNode pre = null;
            ListNode head = null;
            int high = 0;
            while (l1 != null || l2 != null || high != 0)
            {
                var d1 = l1?.val ?? 0;
                var d2 = l2?.val ?? 0;
                var sum = d1 + d2 + high;

                high = (int)(sum / 10);
                var data = sum % 10;

                var current = new ListNode(data);
                if (pre != null)
                    pre.next = current;
                else
                    head = current;
                pre = current;

                l1 = l1?.next;
                l2 = l2?.next;
            }
            return head;
        }
    }
}