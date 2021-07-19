using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetCode.Top100;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Top100.Tests
{
    [TestClass()]
    public class Number20Tests
    {
        [TestMethod()]
        public void IsValidTest()
        {
            var sln = new Number20();
            var str = "]";
            sln.IsValid(str);

        }
    }
}