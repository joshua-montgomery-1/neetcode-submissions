public class Solution {
    public bool IsBalanced(TreeNode root) {
        if (root == null)
            return true;

        var leftH = GetHeight(root.left);
        var rightH = GetHeight(root.right);

        if (Math.Abs(leftH - rightH) > 1)
            return false;

        return IsBalanced(root.left) && IsBalanced(root.right);
    }

    public int GetHeight(TreeNode node) {
        if (node == null)
            return 0;

        var leftH = GetHeight(node.left);
        var rightH = GetHeight(node.right);

        return Math.Max(leftH, rightH) + 1;
    }
}