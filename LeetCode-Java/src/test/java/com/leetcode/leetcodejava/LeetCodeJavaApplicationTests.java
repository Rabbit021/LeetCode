package com.leetcode.leetcodejava;

import com.leetcode.leetcodejava.algorithm.Solution;
import org.junit.jupiter.api.Test;
import org.springframework.boot.test.context.SpringBootTest;
import org.springframework.util.Assert;

@SpringBootTest
class LeetCodeJavaApplicationTests {
    @Test
    void TestSolution() {
        Solution sln = new Solution();
        int rst = sln.singleNumber(new int[]{2, 2, 1});
        Assert.isTrue(rst == 1, "错误");

        int rst2  = sln.singleNumber(new int[]{2, 2, 1});
        Assert.isTrue(rst2 == 1, "错误");
    }
}
