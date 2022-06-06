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
    public IList<int> InorderTraversal(TreeNode root) {
        // List will hold our inorder traversal 
        // (pre-allocated according to constraint to gain some speed)
        var output = new List<int>(100);
        
        // Stack will store context for our visits.
        var treeStack = new Stack<TreeNode>(100);
        var ctx = root;
        
        // While there's still something to process...
        while ((ctx != null) || (treeStack.Count != 0)){
            // If we're currently at a node cascade leftward.
            if(ctx != null){
                treeStack.Push(ctx);
                ctx = ctx.left;
            // Otherwise return leftmost context and visit it.
            } else {
                ctx = treeStack.Pop();
                output.Add(ctx.val);
                
                // Shift context to right sub-tree to look for new leftmost context.
                ctx = ctx.right;
            }
        }
        return output;
    }
}