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
    private static IList<int> PostorderTraversalRecursive(TreeNode root, IList<int> output){
        if(root == null){
            return output;
        }
        PostorderTraversalRecursive(root.left, output);
        PostorderTraversalRecursive(root.right, output);
        output.Add(root.val);
        return output;
    }
    
    // There are single stack variants but I feel like the two stack method is easiest to 
    // understand.
    private static IList<int> PostorderTraversalIterative(TreeNode root){
        var output = new List<int>();
        if(root != null) {
            // First stack is to navigate tree in reverse Postorder
            var stack = new Stack<TreeNode>();
            
            // Second stack stores reverse Postorder in FILO letting us visit in correct Postorder.
            var visited = new Stack<TreeNode>();
            stack.Push(root);
            
            // While still navigating...
            while(stack.Count != 0){
                // Navigate in reverse postorder
                var node = stack.Pop();
                visited.Push(node);
                if(node.left != null){
                    stack.Push(node.left);   
                }
                if(node.right != null){
                    stack.Push(node.right);
                }
                
                // The moment the stack is empty dump contents in FILO to output.
                while(stack.Count == 0 && visited.Count != 0){
                    output.Add(visited.Pop().val);
                }
            }
        }
        return output;
    }
    public IList<int> PostorderTraversal(TreeNode root) {
        return PostorderTraversalIterative(root);    
    }
}