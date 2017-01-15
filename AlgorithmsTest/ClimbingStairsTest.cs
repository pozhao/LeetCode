using System;
using System.Collections.Generic;
using Algorithms;
using Algorithms.Utils;
using Xunit;
namespace AlgorithmsTest
{
    public class ClimbingStairsTest
    {
        [Theory]
        [InlineData()]
        public void TestMethod(int n, int output)
        {
            Assert.Equal(output, Solution070.ClimbStairs(n));
        }
    }
}

