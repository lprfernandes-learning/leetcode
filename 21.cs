/*
21. Merge Two Sorted Lists
Easy
Topics
conpanies icon
Companies
You are given the heads of two sorted linked lists list1 and list2.

Merge the two lists into one sorted list. The list should be made by splicing together the nodes of the first two lists.

Return the head of the merged linked list.

 

Example 1:


Input: list1 = [1,2,4], list2 = [1,3,4]
Output: [1,1,2,3,4,4]
Example 2:

Input: list1 = [], list2 = []
Output: []
Example 3:

Input: list1 = [], list2 = [0]
Output: [0]
 

Constraints:

The number of nodes in both lists is in the range [0, 50].
-100 <= Node.val <= 100
Both list1 and list2 are sorted in non-decreasing order.
*/



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

class Solution
{
    public ListNode MergeTwoLists(ListNode list1, ListNode list2)
    {

        ListNode head = new ListNode();
        //base case
        if (list1 is null)
            return list2;
        if (list2 is null)
            return list1;

        //recursion case
        if (list1.val < list2.val)
        {
            head = list1;
            list1 = list1.next;
        }
        else
        {
            head = list2;
            list2 = list2.next;
        }

        head.next = MergeTwoLists(list1, list2);
        return head;
    }
}