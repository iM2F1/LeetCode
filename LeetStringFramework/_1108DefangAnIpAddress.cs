namespace LeetStringFramework
{
    public class _1108DefangAnIpAddress
    {
        public string DefangIPaddr(string address)
        {
            var splist = address.Trim().Split('.');
            return string.Format("{0}[.]{1}[.]{2}[.]{3}",splist[0], splist[1], splist[2], splist[3]);
        }
    }
}