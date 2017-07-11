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
    public class _237_DeleteNodeinaLinkedList
    {
        public void DeleteNode(ListNode node)
        {
            if (node != null)
            {
                node.val = node.next.val;
                node.next = node.next.next;
            }
        }
    }
}
