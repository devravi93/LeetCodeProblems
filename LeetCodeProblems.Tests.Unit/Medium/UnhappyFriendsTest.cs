using LeetCodeProblems.Medium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.Tests.Unit.Medium
{
    public class UnhappyFriendsTest
    {
        [Fact]
        public void Success()
        {
            UnhappyFriends unhappyFriends = new UnhappyFriends();
            int n = 4;
            var preferences = new int[][]
            {
                new int[] { 1, 2, 3 },
                new int[] { 3, 2, 0 },
                new int[] { 3, 1, 0 },
                new int[] { 1, 2, 0 }
            };

            var pairs = new int[][]
            {
                new int[] { 0, 1 },
                new int[] { 2, 3 }
            };
            var result = unhappyFriends.Process(n, preferences, pairs);
            Assert.Equal(2, result);
        }

        [Fact]
        public void Success_2()
        {
            UnhappyFriends unhappyFriends = new UnhappyFriends();
            int n = 2;
            var preferences = new int[][]
            {
                new int[] { 1 },
                new int[] { 0 },
            };

            var pairs = new int[][]
            {
                new int[] { 1, 0 }
            };
            var result = unhappyFriends.Process(n, preferences, pairs);
            Assert.Equal(0, result);
        }

        [Fact]
        public void Success_3()
        {
            UnhappyFriends unhappyFriends = new UnhappyFriends();
            int n = 4;
            var preferences = new int[][]
             {
                new int[] { 1, 3, 2 },
                new int[] { 2, 3, 0 },
                new int[] { 1, 3, 0 },
                new int[] { 0, 2, 1 }
             };

            var pairs = new int[][]
            {
                new int[] { 1, 3 },
                new int[] { 0, 2 }
            };
            var result = unhappyFriends.Process(n, preferences, pairs);
            Assert.Equal(4, result);
        }

        [Fact]
        public void Success_4()
        {
            UnhappyFriends unhappyFriends = new UnhappyFriends();
            int n = 4;
            var preferences = new int[][]
             {
                new int[] { 1, 3, 2 },
                new int[] { 2, 3, 0 },
                new int[] { 1, 0, 3 },
                new int[] { 1, 0, 2 }
             };

            var pairs = new int[][]
            {
                new int[] { 2, 1 },
                new int[] { 3, 0 }
            };
            var result = unhappyFriends.Process(n, preferences, pairs);
            Assert.Equal(0, result);
        }
    }
}
