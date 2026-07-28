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
    public int MaxDepth(TreeNode root) {

        if(root == null)
        return 0;

        if(root.right == null && root.left == null)
        return 1;

        var leftMax = MaxDepth(root.left);
        var rightMax = MaxDepth(root.right);

        if(leftMax > rightMax) return leftMax + 1;
        return rightMax + 1;
        
    }
}
