using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeCSharp
{
    public class _3_LongestSubstringWithoutRepeatingCharacters
    {
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
