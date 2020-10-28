using System.Collections.Generic;

namespace LeetStringFramework
{
    public class _1480_Running_Sum_of_1d_Array
    {
        public int[] RunningSum(int[] nums)
        {

            var sum = 0;
            var ret = new List<int>();
            foreach (var num in nums)
            {
                sum += num;
                ret.Add(sum);
            }

            return ret.ToArray();
        }
        //var ret = new int[nums.Length];
        //for (int i = 0; i < nums.Length; i++)
        //{
        //    ret[i] = sum + nums[i];
        //    sum = ret[i];
        //}
    }
}