using System;
using System.Collections.Generic;
using Algorithms;
using Algorithms.Utils;
using Xunit;
namespace AlgorithmsTest
{
    public class SearchinRotatedSortedArrayIITest
    {
        [Theory]
        [InlineData()]
        public void TestMethod(int[] nums, int target, bool output)
        {
            Assert.Equal(output, Solution081.Search(nums, target));
        }
    }
}

