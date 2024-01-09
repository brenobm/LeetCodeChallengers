using LeetCodeChallengers.LinkedList;

namespace LeetCodeChallengers.DivideAndConquer;

/*
 * 23. Merge k Sorted Lists
 * 
 * You are given an array of k linked-lists lists, each linked-list is sorted in ascending order.
 * Merge all the linked-lists into one sorted linked-list and return it.
 * 
 * Example 1:
 * Input: lists = [[1,4,5],[1,3,4],[2,6]]
 * Output: [1,1,2,3,4,4,5,6]
 * Explanation: The linked-lists are:
 * [
 *    1->4->5,
 *    1->3->4,
 *    2->6
 * ]
 * merging them into one sorted list:
 * 1->1->2->3->4->4->5->6
 * 
 * Example 2:
 * Input: lists = []
 * Output: []
 * 
 * Example 3:
 * Input: lists = [[]]
 * Output: []
 * 
 * Constraints:
 * k == lists.length
 * 0 <= k <= 104
 * 0 <= lists[i].length <= 500
 * -104 <= lists[i][j] <= 104
 * lists[i] is sorted in ascending order.
 * The sum of lists[i].length will not exceed 104.
 */
public class MergeKSortedListsSolution23
{
    public ListNode MergeKLists(ListNode[] lists)
    {
        var node = null as ListNode;
        var head = null as ListNode;
        var last = null as ListNode;
        
        while ((node = FindMinNode(lists)) != null)
        {
            if (node == null)
            {
                return head;
            }

            if (head == null)
            {
                head = node;
            }
            if (last != null)
            {
                last.next = node;
            }
            last = node;
        }

        return head;
    }

    private ListNode FindMinNode(ListNode[] lists)
    {
        var minNode = null as ListNode;
        var minNodeIndex = -1;
        for (var i  = 0; i < lists.Length; i++) 
        { 
            if (lists[i] !=  null)
            {
                if (minNode == null || lists[i].val < minNode.val)
                {
                    minNode = lists[i];
                    minNodeIndex = i;
                }
            }
        }

        if (minNode != null)
        {
            lists[minNodeIndex] = minNode.next;
            minNode.next = null;
        }

        return minNode;
    }
}

public class ListNode
{
    public int val;
    public ListNode next;
    public ListNode(int val = 0, ListNode next = null)
    {
        this.val = val;
        this.next = next;
    }
}