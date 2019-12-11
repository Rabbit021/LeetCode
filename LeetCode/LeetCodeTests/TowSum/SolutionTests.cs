using LeetCode.TowSum;
using System.Collections.Generic;
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

       
    }
}