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
    private sealed record HeightNode(int height, TreeNode n);
    
    // I can't wrap my head around why this is so slow.
    // This should be roughly equivalent to a memoized solution.
    private static int MinDepthIterative(TreeNode root){
        // Base Case
        if(root == null){
            return 0;
        }
        
        // Stack Traversal
        var stack = new Stack<HeightNode>();
        stack.Push(new HeightNode(1, root));
        var minHeight = Int32.MaxValue;
        
        // Traverse
        while(stack.Count != 0){
            var ctx = stack.Pop();
            // Filter out uneeded work.
            if(ctx.height >= minHeight){
                continue;
            // Extra comparison is uneeded because uneeded checks are already filtered.
            } else if (ctx.n.left == null && ctx.n.right == null) {
                minHeight = ctx.height;
            } else {
                // Push to traverse as usual.
                if(ctx.n.left != null){
                    stack.Push(new HeightNode(ctx.height+1,ctx.n.left));   
                }
                if(ctx.n.right != null){
                    stack.Push(new HeightNode(ctx.height+1,ctx.n.right));
                }
            }
        }
        return minHeight;
    }
    
    private static int MinDepthRecursive(TreeNode root){
        if(root == null){
            return 0;
        }
        if(root.left == null && root.right == null){
            return 1;
        }
        if(root.left == null){
            return MinDepthRecursive(root.right) + 1;
        }
        if(root.right == null){
            return MinDepthRecursive(root.left) + 1;
        }
        return Math.Min(MinDepthRecursive(root.left),MinDepthRecursive(root.right)) + 1;
    }
    public int MinDepth(TreeNode root) {
        return MinDepthIterative(root);
    }
}