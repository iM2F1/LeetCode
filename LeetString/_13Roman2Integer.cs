using System;

namespace LeetString
{
    public class _13Roman2Integer
    {
        public int RomanToInt(string s)
        {
            var BArray = s.ToCharArray(0, s.Length);

            var total = 0;
            //total += Roman2IntSp(s);

            var strLength = s.Length - 1;
            for (int i=0;i<s.Length;i++)
            {
                if (i < strLength)
                {
                    var temp = Roman2IntSp(s.Substring(i, 2));
                    if (temp > 0)
                    {
                        total += temp;
                        i++;
                        continue;
                    }

                }
                total += Roman2Int(s[i]);


            }
            return total;
        }

        public int Roman2IntSp(string input)
        {
            switch (input)
            {
                case "IV":
                    return 4;
                case "IX":
                    return 9;
                case "XL":
                    return 40;
                case "XC":
                    return 90;
                case "CD":
                    return 400;
                case "CM":
                    return 900;
            }

            return 0;

        }
        public int Roman2Int(Char RomanB)
        {

            switch (RomanB)
            {
                case 'I':
                    return 1;
                case 'V':
                    return 5;
                case 'X':
                    return 10;
                case 'L':
                    return 50;
                case 'C':
                    return 100;
                case 'D':
                    return 500;
                case 'M':
                    return 1000;
                default:
                    return 0;
                    break;
            }

        }
    }


}
