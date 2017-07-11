using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeCSharp
{
    public class _3_LongestSubstringWithoutRepeatingCharacters
    {
        /*
            Hint: use Dictionary(HashMap) for slicing window [i,j), 
            if s[j] is already inside the window, i move forward, 
            if s[j] not inside the window, the put s[j] in the dict with index j in as (k, v) pair.
            Be careful: the index of s[j] may be not in the window but before the window.
            e.g. abc[def]a (i = 3, j = 6), i should be max of (0,3). 
         */
        public int LengthOfLongestSubstring(string s)
        {
            if (s == null)
            {
                return 0;
            }
            int n = s.Length, ans = 0;
            Dictionary<char, int> dict = new Dictionary<char, int>();
            for (int i = 0, j = 0; j < n; j++)
            {
                if (!dict.ContainsKey(s[j]))
                {
                    dict.Add(s[j], j);
                } else
                {
                    i = Math.Max(i, dict[s[j]] + 1);
                    dict[s[j]] = j;
                }
                ans = Math.Max(ans, j - i + 1);
            }
            return ans;
        }
    }
}
