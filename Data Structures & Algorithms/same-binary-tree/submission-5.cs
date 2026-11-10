public class Solution {
    public bool IsSameTree(TreeNode p, TreeNode q) {
        return IsSame(p, q);
    }

    public bool IsSame(TreeNode p, TreeNode q) {
        if (p == null && q == null) return true;
        if (p == null || q == null) return false;

        if (p.val != q.val) return false;

        var left = IsSame(p.left, q.left);
        var right = IsSame(p.right, q.right);

        if (left == false || right == false)
            return false;

        return true;
    }
}