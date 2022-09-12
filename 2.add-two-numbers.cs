/*
 * @lc app=leetcode id=2 lang=csharp
 *
 * [2] Add Two Numbers
 */

// @lc code=start
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
public class Solution 
{
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2) 
    {
        ListNode startNode = null;
        ListNode previousNode = null;
        int carry = 0;

        while (l1 != null || l2 != null || carry != 0) 
        {
            var valueAdded = (l1?.val ?? 0) + (l2?.val ?? 0) + carry;
            var value = valueAdded % 10;
            carry = (int)valueAdded/10;
            
            var currentNode = new ListNode(value, null);
            if (startNode == null) 
            {
                startNode = currentNode;
            }
            else 
            {
                previousNode.next = currentNode;
            }
            previousNode = currentNode;
            
            l1 = l1?.next;
            l2 = l2?.next;
        }

        return startNode;
    }
}
// @lc code=end

