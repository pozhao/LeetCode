using System;
using System.Collections.Generic;
using Algorithms;
using Algorithms.Utils;
using Xunit;
namespace AlgorithmsTest
{
    public class MergeSortedArrayTest
    {
        [Theory]
        [InlineData()]
        public void TestMethod(int[] nums1, int m, int[] nums2, int n)
        {
            Solution088.Merge(nums1, m, nums2, n);
            Assert.True(true);
        }
    }
}

