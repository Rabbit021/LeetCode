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
    public class StringAddTests
    {
        List<TestData> datas;

        [TestInitialize]
        public void Intlize()
        {
            datas = new List<TestData>
            {
                new TestData{  Input1="0",Input2="2", Result="2"}
            };
        }
        public class TestData
        {
            public string Input1;
            public string Input2;
            public string Result;
        }

        [TestMethod()]
        public void AddStringsTest()
        {
            var sln = new StringAdd();
            foreach (var itr in datas)
            {
                var rst = sln.AddStrings(itr.Input1, itr.Input2);
                Assert.IsTrue(string.Equals(rst, itr.Result));
            }
        }
    }
}