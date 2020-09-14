using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace LeetStringFramework
{
    public class _535_Encode_and_Decode_TinyURL
    {
        private Dictionary<string,string> ShortURLList= new Dictionary<string, string>();
        // Encodes a URL to a shortened URL
        public string encode(string longUrl)
        {
            var _md5 = MD5CryptoServiceProvider.Create();
            var md5Str = _md5.ComputeHash(Encoding.UTF8.GetBytes(longUrl));
            var shortURL = string.Format($@"http://tinyurl.com/{0}", md5Str.ToString().Substring(0, 6));
            ShortURLList.Add(shortURL,longUrl);
            return shortURL;
        }

        // Decodes a shortened URL to its original URL.
        public string decode(string shortUrl)
        {
            return ShortURLList[shortUrl];
        }
    }
}