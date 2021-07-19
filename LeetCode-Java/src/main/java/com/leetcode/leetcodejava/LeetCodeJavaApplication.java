package com.leetcode.leetcodejava;

import org.springframework.boot.CommandLineRunner;
import org.springframework.boot.SpringApplication;
import org.springframework.boot.autoconfigure.SpringBootApplication;

/**
 * @author wangheng
 */
@SpringBootApplication
public class LeetCodeJavaApplication implements CommandLineRunner {
    public static void main(String[] args) {
        SpringApplication.run(LeetCodeJavaApplication.class, args);
    }

    @Override
    public void run(String... args) throws Exception {
        System.out.println("Start");
    }
}


