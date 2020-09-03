namespace LeetString
{
    public class _1221_Split_a_String_in_Balanced_Strings
    {
        public int BalancedStringSplit(string s)
        {
            var r = 0;
            var l = 0;
            //var subStart = 0;
            //var subEnd = 0;
            var count = 0;
            for (int i=0;i<s.Length;i++)
            {
                switch (s[i])
                {
                    case 'R':
                        r++;
                        break;
                    case 'L':
                        l++;
                        break;
                }

                if (r == l)
                {
                    count++;
                    r = l = 0;
                }
                   
            }
            return count;
        }
    }
}