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
public class Solution 
    // Simply look ahead and see if left child is a leaf node. If so return it's value.
    // Otherwise walk the whole tree.
    public int SumOfLeftLeaves(TreeNode root) {
        if(root == null){ return 0; }
        if(root.left != null && root.left.left == null && root.left.right == null){
            return root.left.val + SumOfLeftLeaves(root.right);
        } else {
            return SumOfLeftLeaves(root.left) + SumOfLeftLeaves(root.right);
        }
    }
}