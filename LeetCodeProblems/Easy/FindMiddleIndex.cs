using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.Easy
{
    /// <summary>
    /// Problem Statement :
    /// Given a 0-indexed integer array nums, find the leftmost middleIndex (i.e., the smallest amongst all the possible ones).
    /// A middleIndex is an index where nums[0] + nums[1] + ... + nums[middleIndex - 1] == nums[middleIndex + 1] + nums[middleIndex + 2] + ... + nums[nums.length - 1].
    /// If middleIndex == 0, the left side sum is considered to be 0. Similarly, if middleIndex == nums.length - 1, the right side sum is considered to be 0.
    /// Return the leftmost middleIndex that satisfies the condition, or -1 if there is no such index.
    /// </summary>
    public class FindMiddleIndex
    {
        public int Process(int[] nums)
        {
            int result = -1;
            for (int i = 0; i < nums.Length; i++)
            {
                int sumLeft = 0;
                int sumRight = 0;

                if (i == 0)
                {
                    sumRight = nums.Take(new Range(i + 1, nums.Length)).Sum();
                }
                else if (i == nums.Length - 1)
                {
                    sumLeft = nums.Take(new Range(0, i)).Sum();
                }
                else
                {
                    sumLeft = nums.Take(new Range(0, i)).Sum();
                    sumRight = nums.Take(new Range(i + 1, nums.Length)).Sum();
                }


                if (sumLeft == sumRight)
                {
                    result = i;
                    break;
                }
            }

            return result;
        }
    }
}
