using LeetCodeProblems.Easy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.Tests.Unit.Easy
{
    public class FindMiddleIndexTest
    {
        [Fact]
        public void Success()
        {
            var middleIndex = new FindMiddleIndex();
            var arr = new int[] { 2, 3, -1, 8, 4 };
            int result = middleIndex.Process(arr);

            Assert.Equal(3, result);
        }

        [Fact]
        public void NoMiddleIndex()
        {
            var middleIndex = new FindMiddleIndex();
            var arr = new int[] { 2, 5 };
            int result = middleIndex.Process(arr);

            Assert.Equal(-1, result);
        }

        [Fact]
        public void Success_Case2()
        {
            var middleIndex = new FindMiddleIndex();
            var arr = new int[] { 1, -1, 4 };
            int result = middleIndex.Process(arr);

            Assert.Equal(2, result);
        }

        [Fact]
        public void Success_Case3()
        {
            var middleIndex = new FindMiddleIndex();
            var arr = new int[] { 1 };
            int result = middleIndex.Process(arr);

            Assert.Equal(0, result);
        }

    }
}
