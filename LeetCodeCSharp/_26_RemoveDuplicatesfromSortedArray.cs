using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeCSharp
{
    public class _26_RemoveDuplicatesfromSortedArray
    {
        /*
        Hint: use two Pointers, fast and slow, 
        when nums[fast] != nums[slow], make nums[slow + 1] = nums[fast], and let slow++, fast++;
        when nums[fast] == nums[slow], just keep moving fast, i.e. fast++),  until fast pointer reach the end.
        */

        public int RemoveDuplicates(int[] nums)
        {
            if (nums == null || nums.Length == 0)
            {
                return 0;
            }
            int slow = 0;
            for (int fast = 0; fast < nums.Length; fast++)
            {
                if (nums[slow] != nums[fast])
                {
                    nums[slow + 1] = nums[fast];
                    slow++;
                }
            }
            return slow + 1;
        }

    }
}
