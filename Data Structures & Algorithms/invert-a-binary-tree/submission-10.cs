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
    public TreeNode InvertTree(TreeNode root) {
        return Invert(root);
    }

    public TreeNode Invert(TreeNode root)
    {
        if(root == null)
        {
            return root;
        }

        TreeNode left = root.left;
        TreeNode right = root.right;
        
        root.left = Invert(right);
        root.right = Invert(left);

        return root;
    }
}
