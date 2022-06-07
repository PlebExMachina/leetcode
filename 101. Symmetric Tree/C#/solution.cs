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
    // Recursive solution.
    static private bool compare(TreeNode l, TreeNode r){
        if(l == null || r == null){
            return l == r;
        }
        if(l.val != r.val){
            return false;
        }
        return compare(l.left, r.right) && compare(l.right, r.left);
    }
    public bool IsSymmetric(TreeNode root) {
        return (root == null) || compare(root.left, root.right);
    }
}


// The key part of this problem is that each tree needs to be walked in a different way.
// An iterative solution can occur by performing a walk with two stacks
//    One sub-tree would be walked with a Preorder Traversal
//    The other sub-tree would be walked with a Postorder Traversal.
//  
//    Performing these walks simultaiously and performing the comparisons would have
//    the same effect as the recursive algorithm.