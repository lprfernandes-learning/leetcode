/*
530. Minimum Absolute Difference in BST
Easy

Given the root of a Binary Search Tree (BST), return the minimum absolute difference between the values of any two different nodes in the tree.

 

Example 1:


Input: root = [4,2,6,1,3]
Output: 1
Example 2:


Input: root = [1,0,48,null,null,12,49]
Output: 1
 

Constraints:

The number of nodes in the tree is in the range [2, 104].
0 <= Node.val <= 105
 

Note: This question is the same as 783: https://leetcode.com/problems/minimum-distance-between-bst-nodes/

*/



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
    int? prev = null;
    int minDif = int.MaxValue;
    public int GetMinimumDifference(TreeNode root)
    {
        //in order traversal
        if (root.left is not null) GetMinimumDifference(root.left);

        if (prev != null) minDif = Math.Min(minDif, root.val - prev.Value);

        prev = root.val;

        if (root.right is not null) GetMinimumDifference(root.right);

        return minDif;
    }
}