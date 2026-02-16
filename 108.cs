/*
108. Convert Sorted Array to Binary Search Tree
Easy
Given an integer array nums where the elements are sorted in ascending order, convert it to a height-balanced binary search tree.

 

Example 1:


Input: nums = [-10,-3,0,5,9]
Output: [0,-3,9,-10,null,5]
Explanation: [0,-10,5,null,-3,null,9] is also accepted:

Example 2:


Input: nums = [1,3]
Output: [3,1]
Explanation: [1,null,3] and [3,1] are both height-balanced BSTs.
 

Constraints:

1 <= nums.length <= 104
-104 <= nums[i] <= 104
nums is sorted in a strictly increasing order.
*/

using System.Linq.Expressions;

public class TreeNode
{
    public int val;
    public TreeNode left;
    public TreeNode right;
    public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
    {
        this.val = val;
        this.left = left;
        this.right = right;
    }
}

public class Solution
{
    public TreeNode SortedArrayToBST(int[] nums)
    {
        if (nums is null || nums.Length == 0)
        {
            return null;
        }

        return BuildTree(nums, 0, nums.Length - 1);

    }

    private TreeNode BuildTree(int[] nums, int i, int j)
    {
        if (j < i) return null;

        int mid = j + (i - j) / 2;
        TreeNode node = new(nums[mid]);

        node.left = BuildTree(nums, i, mid - 1);
        node.right = BuildTree(nums, mid + 1, j);

        return node;
    }
}