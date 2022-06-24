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
    private static TreeNode SortedArrayToBSTRecursive(int[] nums, int low, int high){
        if(low > high){
            return null;
        }
        int mid = (low + high) / 2;
        var root = new TreeNode(nums[mid]);
        root.left = SortedArrayToBSTRecursive(nums,low,mid-1);
        root.right = SortedArrayToBSTRecursive(nums,mid+1, high);
        return root;
    }
    
    // Tuple to contain context information when bouncing off stack.
    private sealed record RangeNode(int low, int high, bool isLeft,TreeNode parent);
    private static TreeNode SortedArrayToBSTIterative(int[] nums){
        // Stack for Tree Traversal
        var stack = new Stack<RangeNode>();     
        
        // Create Root
        int rootMid = nums.Length / 2;
        var root = new TreeNode(nums[rootMid]);
        
        // Push Left / Right Ranges
        stack.Push(new RangeNode(0, rootMid-1, true, root));
        stack.Push(new RangeNode(rootMid+1, nums.Length-1, false, root));
        
        // While traversing...
        while(stack.Count != 0){
            // If range is valid...
            var ctx = stack.Pop();
            if(ctx.low <= ctx.high){
                // Then initialize Left/Right Node depending on information.
                int ctxMid = (ctx.low + ctx.high) / 2;
                TreeNode newParent = null;
                if(ctx.isLeft) {
                    ctx.parent.left = new TreeNode(nums[ctxMid]);
                    newParent = ctx.parent.left;
                } else {
                    ctx.parent.right = new TreeNode(nums[ctxMid]);
                    newParent = ctx.parent.right;
                }
                
                // Push sub-left and sub-right ranges with newly made node as the parent.
                stack.Push(new RangeNode(ctx.low,ctxMid-1, true, newParent));
                stack.Push(new RangeNode(ctxMid+1,ctx.high, false, newParent));
            }
        }
        return root;
    }
    public TreeNode SortedArrayToBST(int[] nums) {
        return SortedArrayToBSTIterative(nums);
    }
}