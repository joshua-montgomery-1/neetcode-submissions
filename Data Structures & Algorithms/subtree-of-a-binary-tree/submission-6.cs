/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */

public class Solution {
    public bool IsSubtree(TreeNode root, TreeNode subRoot) {
        if (root == null || subRoot == null)
            return false;

        if (root.val == subRoot.val && IsSame(root, subRoot))
            return true;

        return IsSubtree(root.left, subRoot) || IsSubtree(root.right, subRoot);
    }

    public bool IsSame(TreeNode p, TreeNode q) {
        if (p == null && q == null)
            return true;
        if (p == null || q == null)
            return false;

        if (p.val != q.val)
            return false;

        var left = IsSame(p.left, q.left);
        var right = IsSame(p.right, q.right);

        if (left == false || right == false)
            return false;

        return true;
    }
}
