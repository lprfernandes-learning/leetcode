/*
101. Symmetric Tree
Easy
Topics
conpanies icon
Companies
Given the root of a binary tree, check whether it is a mirror of itself (i.e., symmetric around its center).

 

Example 1:


Input: root = [1,2,2,3,4,4,3]
Output: true
Example 2:


Input: root = [1,2,2,null,3,null,3]
Output: false
 

Constraints:

The number of nodes in the tree is in the range [1, 1000].
-100 <= Node.val <= 100
 

Follow up: Could you solve it both recursively and iteratively?

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
    public bool IsSymmetric(TreeNode root)
    {
        if (root == null) return true;

        return IsSymmetric(root.left, root.right);
    }

    public bool IsSymmetric(TreeNode left, TreeNode right)
    {
        if (left is null && right is null) return true;
        if (left is null || right is null) return false;

        if (left.val != right.val) return false;

        return IsSymmetric(left.left, right.right) && IsSymmetric(left.right, right.left);
    }
}