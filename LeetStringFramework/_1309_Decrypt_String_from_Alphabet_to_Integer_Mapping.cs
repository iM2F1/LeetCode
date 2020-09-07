using System.Collections.Generic;
using System.Runtime.InteropServices.ComTypes;

namespace LeetStringFramework
{
    public class _1309_Decrypt_String_from_Alphabet_to_Integer_Mapping
    {
        public string FreqAlphabets(string s)
        {
            int currentPos=0;
            string ret = string.Empty;
            var Dict = new Dictionary<string, string>()
            {
                { "1","a"},{ "2","b"},{ "3","c"},{ "4","d"},{ "5","e"},{ "6","f"},{ "7","g"},{ "8","h"},{ "9","i" },
                { "10#","j"},{ "11#","k"},{ "12#","l"},{ "13#","m"},{ "14#","n"},{ "15#","o"},{ "16#","p"},
                { "17#","q"},{ "18#","r"},{ "19#","s"},{ "20#","t"},{ "21#","u"},{ "22#","v"},{ "23#","w"},
                { "24#","x"},{ "25#","y"},{ "26#","z"}
            };
            while ((s.Length - currentPos) > 0)
            {
                var diff = s.Length - currentPos;
                if (diff >= 3)
                {
                    if (s[currentPos + 2] == '#')
                    {

                        ret += Dict[s.Substring(currentPos, 3)];
                        currentPos += 3;
                        continue;
                    }
                }

                ret += Dict[s.Substring(currentPos, 1)];
                currentPos++;

            }

            return ret;
        }
    }

}