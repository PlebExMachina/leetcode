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
    private static int GetDepth(TreeNode root){
        if(root == null){
            return 0;
        }
        return 1+Math.Max(GetDepth(root.left),GetDepth(root.right));
    }
    
    private static bool IsBalancedRecursive(TreeNode root){
        if(root == null){
            return true;
        }
        int depthDelta = GetDepth(root.left) - GetDepth(root.right);
        if(depthDelta < -1 || depthDelta > 1){
            return false;
        }
        return IsBalancedRecursive(root.left) && IsBalancedRecursive(root.right);
    }
    
    
    public bool IsBalanced(TreeNode root) {
        return IsBalancedRecursive(root);   
    }
}