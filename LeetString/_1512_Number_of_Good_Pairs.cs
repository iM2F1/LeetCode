using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetString
{
    public class _1512_Number_of_Good_Pairs
    {
        public int NumIdenticalPairs(int[] nums)
        {
            var count = 0;
            var Dict = new List<int>();
            for (int i =0;i<nums.Length;i++)
            {
                for ( int j =i+1 ;j<nums.Length;j++)
                {
                    if (nums[i] == nums[j])
                    {
                        count++;
                        continue;
                    }
                }


            }
            return count;
        }
    }
}
