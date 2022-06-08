using System.Threading;
using System.Threading.Tasks;
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
    private static bool HasPathSumRecursive(TreeNode root, int targetSum){
        // Terminate if no more path, otherwise deduct running sum.
        if(root == null){
            return false;
        } else {
             targetSum -= root.val;   
        }
        
        // If running sum is 0 and it's a leaf node then a path has been found.
        if((targetSum == 0) && (root.left == null) && (root.right == null)){
            return true;
        // Otherwise continue searching sub-trees.
        } else {
            return 
                HasPathSumRecursive(root.right, targetSum) 
                || 
                HasPathSumRecursive(root.left, targetSum);
        }        
    }
    
    private sealed record SumNode(TreeNode n, int sum);
    
    private static bool HasPathSumIterative(
        TreeNode root, 
        int targetSum
    ){
        // If root is empty then no paths can exist.
        if(root == null){
            return false;
        } else {
            // Make Stack for DFS
            var stack = new Stack<SumNode>();
            stack.Push(new SumNode(root, targetSum - root.val));
            
            // Until Search Finishes
            while(stack.Count > 0){ 
                var ctx = stack.Pop();
                
                // If it's a leaf node and sum is zero then a path has been found.
                if((ctx.sum == 0) && (ctx.n.left == null) && (ctx.n.right == null)){
                    return true;
                // Otherwise if applicable push sub-trees.
                } else {
                    if(ctx.n.left != null ){ 
                        stack.Push(new SumNode(
                            ctx.n.left, 
                            ctx.sum - ctx.n.left.val
                        )); 
                    }
                    if(ctx.n.right != null){ 
                        stack.Push(new SumNode(
                            ctx.n.right, 
                            ctx.sum - ctx.n.right.val
                        )); 
                    }
                }
            }
            
            // If search has finished unsuccessfuly then no such path exists.
            return false;   
        }
    }
    
    
    // Search both trees in parallel.
    // General CPU solution could be made with BFS expansion before handing it off to DFS algorithm.
    public bool HasPathSumParallel(TreeNode root, int targetSum){
        // If no paths then return false, otherwise deduct sum from start.
        if(root == null){
            return false;
        } else {
            targetSum -= root.val;
        }
        
        // Because we are bypassing root we need to check if it's a valid path.
        if((targetSum == 0) && (root.left == null) && (root.right == null)){
            return true;
        }   
        
        // Contains our outputs.
        bool r1 = false, r2 = false;
        Parallel.Invoke(
            () => r1 = HasPathSumIterative(root.left, targetSum),
            () => r2 = HasPathSumIterative(root.right, targetSum)
        );
        return r1 || r2;
    }
    
    public bool HasPathSum(TreeNode root, int targetSum) {
        return HasPathSumIterative(root, targetSum);
    }
}