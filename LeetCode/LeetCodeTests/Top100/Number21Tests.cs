using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetCode.Top100;
using System;
using System.Collections.Generic;
using System.Text;
using ListNode = LeetCode.Top100.Number21.ListNode;

namespace LeetCode.Top100.Tests
{
    [TestClass()]
    public class Number21Tests
    {
        [TestMethod()]
        public void MergeTwoListsTest()
        {
            var sln = new Number21();

            ListNode l1 = new ListNode(1);
            {
                var n3 = new ListNode(4, null);
                var n2 = new ListNode(2, n3);
                var n1 = new ListNode(1, n2);
                l1 = n1;
            }

            ListNode l2 = new ListNode(2);
            {
                var n3 = new ListNode(4, null);
                var n2 = new ListNode(3, n3);
                var n1 = new ListNode(1, n2);
                l2 = n1;
            }

            sln.MergeTwoLists(l1, l2);
        }
    }
}