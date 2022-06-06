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
    /*
    private sealed record TreeDepth(TreeNode Node, int Depth);
    // Iterative DFS Solution using Records as Tuples.

        // Edge Case (this will allow me to assume that root is never null)
        if(root == null){ return 0; }

        // Starting at zero...
        int maxDepth = 0;

        // Insert root with metadata of depth 1.
        var depthStack = new Stack<TreeDepth>(100);
        depthStack.Push(new TreeDepth(root, 1));
        
        // While there's still something to process
        // perform right-biased DFS.
        while (depthStack.Count != 0){
            var ctx = depthStack.Pop();
            if(ctx.Node.left != null){
                depthStack.Push(new TreeDepth(ctx.Node.left, ctx.Depth + 1));
            }
            if(ctx.Node.right != null){
                depthStack.Push(new TreeDepth(ctx.Node.right, ctx.Depth + 1));
            }
            maxDepth = Math.Max(maxDepth, ctx.Depth);
        }
        return maxDepth;
        */
    
        // Recursive solution
        if(root == null){
            return 0;
        }
        return 1 + Math.Max(MaxDepth(root.left),MaxDepth(root.right));
    }
}