using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetCode;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Tests
{
    [TestClass()]
    public class StackSlnTests
    {
        [TestMethod()]
        public void IsValidTest()
        {
            var sln = new StackSln();

            var rst = sln.IsValid("()");
            Assert.AreEqual(rst, true);

            rst = sln.IsValid("()[]{}");
            Assert.AreEqual(rst, true);

            rst = sln.IsValid("(]");
            Assert.AreEqual(rst, false);

            rst = sln.IsValid("([)]");
            Assert.AreEqual(rst, false);

            rst = sln.IsValid("{[]}");
            Assert.AreEqual(rst, true);

            rst = sln.IsValid("]");
            Assert.AreEqual(rst, false);
        }
    }
}