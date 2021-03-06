using System;
using System.Collections.Generic;
using Algorithms;
using Algorithms.Utils;
using Xunit;
namespace AlgorithmsTest
{
    public class SubstringwithConcatenationofAllWordsTest
    {
        [Theory]
        [MemberData("InlineData")]
        public void TestMethod(string s, string[] words, IList<int> output)
        {
            Assert.Equal(output, Solution030.FindSubstring(s,words));
        }
        public static IEnumerable<object[]> InlineData
        {
            get
            {
                var driverData = new List<object[]>();
                var s = "barfoothefoobarman";
                var words = new []{"foo","bar"};
                var output = new List<int>{0,9};
                 
                driverData.Add(new object[] { s, words, output });
                
                return driverData;
            }
        }   
    }
}

