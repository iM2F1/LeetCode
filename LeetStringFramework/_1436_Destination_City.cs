using System.Collections.Generic;

namespace LeetStringFramework
{
    public class _1436_Destination_City
    {
        public string DestCity(IList<IList<string>> paths)
        {
            foreach (var pat in paths)
            {
                int count = 0;
                foreach (var path in paths)
                {
                    if (pat[1] == path[0])
                        count++;
                }

                if (count == 0)
                    return pat[1];
            }
            return string.Empty;

        }
    }
}