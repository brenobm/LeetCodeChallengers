using System.Reflection.Metadata.Ecma335;

namespace LeetCodeChallengers.LinkedList;

/*
 * 92. Reverse Linked List II
 * 
 * Given the head of a singly linked list and two integers left and right where left <= right, reverse the nodes of the list from position left to position right, and return the reversed list.
 * 
 * Example 1:
 * Input: head = [1,2,3,4,5], left = 2, right = 4
 * Output: [1,4,3,2,5]
 * 
 * Example 2:
 * Input: head = [5], left = 1, right = 1
 * Output: [5]
 * 
 * Constraints:
 * The number of nodes in the list is n.
 * 1 <= n <= 500
 * -500 <= Node.val <= 500
 * 1 <= left <= right <= n
 * 
 * Follow up: Could you do it in one pass?
 */
public class ReverseLinkedListIISolution92
{
    public ListNode ReverseBetween(ListNode head, int left, int right)
    {
        if (left == right)
        {
            return head;
        }

        var tail = null as ListNode;
        var start = head;

        for (var i = 0; i < left - 1; i++)
        {
            tail = start;
            start = start.next;
        }

        var cur = start;
        var tmp = null as ListNode;
        var old = null as ListNode;

        for (var i = left; i < right + 1; i++)
        {
            tmp = cur.next;
            cur.next = old;
            old = cur;
            cur = tmp;
        }

        if (tail != null)
        {
            tail.next = old;
        }
        else
        {
            head = old;
        }

        start.next = cur;

        return head;
    }
}

//          <-
//1  ->  2  ->  3      4  ->  5
//              c      
//       s
//       l 
//                     t
//              p

//i - 3

/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */


