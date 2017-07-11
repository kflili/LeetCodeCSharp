﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeCSharp
{
    /*
    Hint: use Dictionary(HashTable)
    loop first string, add all the char;
    loop second string, remove all the char. Meanwhile check the dict.
    */
    public class _242_ValidAnagram
    {
        public bool IsAnagram(string s, string t)
        {
            if (s == null)
            {
                return t == null;
            }
            if (t == null)
            {
                return false;
            }
            if (s.Length != t.Length)
            {
                return false;
            }
            Dictionary<char, int> dict = new Dictionary<char, int>();
            for (int i = 0; i < s.Length; i++)
            {
                if (!dict.ContainsKey(s[i]))
                {
                    dict.Add(s[i], 1);
                }
                else
                {
                    dict[s[i]] += 1;
                }
            }
            for (int i = 0; i < t.Length; i++)
            {
                if (!dict.ContainsKey(t[i]))
                {
                    return false;
                }
                dict[t[i]]--;
                if (dict[t[i]] < 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
