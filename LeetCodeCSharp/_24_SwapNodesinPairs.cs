using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeCSharp
{
    //hint: use dymmy node, k1, k2, using more labed node will make solving process more clear.
    public class _24_SwapNodesinPairs
    {
        //Given 1->2->3->4, you should return the list as 2->1->4->3
        public ListNode SwapPairs(ListNode head)
        {
            if (head == null || head.next == null)
            {
                return head;
            }
            ListNode dummy = new ListNode(0)
            {
                next = head
            };
            ListNode pre = dummy;
            ListNode k1 = head;            
            while (k1 != null && k1.next != null)
            {
                ListNode k2 = k1.next;
                k1.next = k2.next;
                k2.next = k1;
                pre.next = k2;
                pre = k1;
                k1 = k1.next;
            }
            return dummy.next;
        }
    }
}
