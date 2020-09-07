using System.Collections.Generic;
using System.Linq;

namespace LeetStringFramework
{
    public class _804_Unique_Morse_Code_Words
    {
        public int UniqueMorseRepresentations(string[] words)
        {
            List<string> MorseStr=new List<string>();
            foreach (var word in words)
            {
                MorseStr.Add(GetMorseCode(word));
            }

            return MorseStr.Distinct().Count();

        }

        private string GetMorseCode(string str)
        {
            var dict = new Dictionary<char, string>()
            {
                { 'a',".-"},{'b',"-..."},{'c',"-.-."},{'d',"-.."},{'e',"."},
                { 'f',"..-."},{'g',"--."},{'h',"...."},{'i',".."},{'j',".---"},{'k',"-.-"},
                {'l',".-.."},{'m',"--"},{'n',"-."},{'o',"---"},{'p',".--."},{'q',"--.-"},
                {'r', ".-."},{'s',"..."},{'t',"-"},{'u',"..-"},{'v',"...-"},{'w',".--"},{'x',"-..-"},
                {'y', "-.--"},{'z',"--.."}
            };
            string ret = string.Empty;
            for (int i = 0; i < str.Length; i++)
            {
                ret += dict[str[i]];
            }
            return ret;
        }
    }
}