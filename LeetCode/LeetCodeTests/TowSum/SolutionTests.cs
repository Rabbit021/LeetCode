using System;
using LeetCode.TowSum;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.TowSum.Tests
{
    [TestCategory("两数之和")]
    [TestClass]
    public class SolutionTests
    {
        private List<TestData> datas;

        [TestInitialize]
        public void Intlize()
        {
            datas = new List<TestData>
            {
                new TestData {Input = new[] {2, 5, 5, 11}, Target = 10, Result = new[] {1, 2}},
                new TestData {Input = new[] {2, 7, 11, 15}, Target = 9, Result = new[] {0, 1}}
            };
        }

        [TestMethod]
        public void TwoSumTest()
        {
            var sln = new Solution();
            foreach (var itr in datas)
            {
                var rst = sln.TwoSum(itr.Input, itr.Target);
                Vaildate(rst, itr.Result);
            }
        }

        [TestMethod()]
        public void TwoSumV2Test()
        {
            var sln = new Solution();
            foreach (var itr in datas)
            {
                var rst = sln.TwoSumV2(itr.Input, itr.Target);
                Vaildate(rst, itr.Result);
            }
        }

        private void Vaildate(int[] result, int[] succes)
        {
            for (var i = 0; i < succes.Length; i++)
                if (succes[i] != result[i])
                    Assert.Fail();
        }

        public class TestData
        {
            public int[] Input;
            public int[] Result;
            public int Target;
        }

        [TestMethod()]
        public void RemoveDuplicatesTest()
        {
            var sln = new Solution();
            var data = new[] { 1 };
            var rst = sln.RemoveDuplicates(data);
            Assert.AreEqual(rst, data.Distinct().Count());

            data = new[] { 1, 1, 2 };
            rst = sln.RemoveDuplicates(data);
            Assert.AreEqual(rst, data.Distinct().Count());

            data = new[] { 0, 0, 1, 1, 1, 2, 2, 3, 3, 4 };
            rst = sln.RemoveDuplicates(data);
            Assert.AreEqual(rst, data.Distinct().Count());
        }

        [TestMethod()]
        public void RemoveElementTest()
        {
            var sln = new Solution();

            var data = new[] { 1 };
            var rst = sln.RemoveElement(data, 3);
            Assert.AreEqual(rst, 1);

            data = new[] { 1 };
            rst = sln.RemoveElement(data, 1);
            Assert.AreEqual(rst, 0);

            data = new[] { 3, 2, 2, 3 };
            rst = sln.RemoveElement(data, 3);
            Assert.AreEqual(rst, 2);

            data = new[] { 0, 1, 2, 2, 3, 0, 4, 2 };
            rst = sln.RemoveElement(data, 2);
            Assert.AreEqual(rst, 5);
        }

        [TestMethod()]
        public void SearchInsertTest()
        {
            var sln = new Solution();
            var data = new[] { 1, 3, 5, 6 };
            var rst = sln.SearchInsert(data, 5);
            Assert.AreEqual(rst, 2);

            data = new[] { 1, 3, 5, 6 };
            rst = sln.SearchInsert(data, 2);
            Assert.AreEqual(rst, 1);

            data = new[] {1, 3, 5, 6};
            rst = sln.SearchInsert(data, 7);
            Assert.AreEqual(rst, 4);

            data = new[] {1, 3, 5, 6};
            rst = sln.SearchInsert(data, 0);
            Assert.AreEqual(rst, 0);
        }
    }
}