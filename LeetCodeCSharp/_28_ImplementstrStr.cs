using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeCSharp
{
    public class _28_ImplementstrStr
    {
        /*
        Hint: use two Pointers
        */
        public int StrStr(string haystack, string needle)
        {
            if (haystack == null || needle == null)
            {
                return -1;
            }
            int m = haystack.Length, n = needle.Length;
            for (int i = 0; i < m - n + 1; i++)
            {
                int j;
                for (j = 0; j < n; j++)
                {
                    if (haystack[i + j] != needle[j])
                    {
                        break;
                    }
                }
                if (j == n)
                {
                    return i;
                }
            }
            return -1;
        }
    }
}
