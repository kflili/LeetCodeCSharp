using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeCSharp
{
    public class _167_TwoSumII
    {
        public int[] TwoSum(int[] numbers, int target)
        {
            int[] result = null;
            if (numbers == null || numbers.Length < 2)
            {
                return result;
            }
            int i = 0, j = numbers.Length - 1;
            while (i < j)
            {
                int v = numbers[i] + numbers[j];
                if (v == target)
                {
                    result = new int[] { i + 1, j + 1 };
                    break;
                }
                else if (v < target)
                {
                    i++;
                }
                else
                {
                    j--;
                }
            }
            return result;
        }
    }
}
