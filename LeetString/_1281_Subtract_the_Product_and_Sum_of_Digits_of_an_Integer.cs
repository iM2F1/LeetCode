using System;

namespace LeetString
{
    public class _1281_Subtract_the_Product_and_Sum_of_Digits_of_an_Integer
    {
        public int SubtractProductAndSum(int n)
        {
            var div = n;
            var str = n.ToString();
            var multiply = 1;
            var plus = 0;
            while (div >= 1)
            {
                var tmp = div % 10;
                multiply *= tmp;
                plus += tmp;
                div = div / 10;
            }

            return (multiply - plus);

            //foreach (var s in str)
            //{
                
            //}
            //return 15;
        }
    }
}
