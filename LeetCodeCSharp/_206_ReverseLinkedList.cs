﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
namespace LeetCodeCSharp
{
    public class _206_ReverseLinkedList
    {
        public ListNode ReverseListIteratively(ListNode head)
        {
            ListNode pre = null, temp;
            while (head != null)
            {
                temp = head.next;
                head.next = pre;
                pre = head;
                head = temp;
            }
            return pre;
        }
        public ListNode ReverseListRecursively(ListNode head)
        {
            if (head == null || head.next == null)
            {
                return head;
            }
            ListNode next = head.next;
            ListNode newHead = ReverseListRecursively(next);
            next.next = head;
            head.next = null;
            return newHead;
        }
    }
}

