using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetCode.Top100;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Top100.Tests
{
    [TestClass()]
    public class Number2Tests
    {
        [TestMethod()]
        public void AddTwoNumbersTest()
        {
            var sln = new Number2();

            //[2,4,3]
            //[5,6,4]

            // [9,9,9,9, 9,9,9]
            // [9,9,9,9]

            Number2.ListNode l1 = new Number2.ListNode(1);
            {
                var n5 = new Number2.ListNode(9, null);
                var n4 = new Number2.ListNode(9, n5);
                var n3 = new Number2.ListNode(9, n4);
                var n2 = new Number2.ListNode(9, n3);
                var n1 = new Number2.ListNode(9, n2);
                l1 = n1;
            }


            Number2.ListNode l2 = new Number2.ListNode(2);
            {
                var n4 = new Number2.ListNode(9, null);
                var n3 = new Number2.ListNode(9, n4);
                var n2 = new Number2.ListNode(9, n3);
                var n1 = new Number2.ListNode(9, n2);
                l2 = n1;
            }

            sln.AddTwoNumbers(l1, l2);
        }
    }
}