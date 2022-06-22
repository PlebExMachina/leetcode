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
    private IList<int> PreorderTraversalRecursive(TreeNode root ,IList<int> output){
        if(root == null){ 
            return output; 
        } else {
            output.Add(root.val);
            PreorderTraversalRecursive(root.left, output);
            PreorderTraversalRecursive(root.right, output);
            return output;
        }
    }
    
    private IList<int> PreorderTraversalIterative(TreeNode root){
        var output = new List<int>();
        if(root == null){
            return output;
        } else {
            var stack = new Stack<TreeNode>();
            stack.Push(root);
            while(stack.Count != 0){
                var node = stack.Pop();
                output.Add(node.val);
                if(node.right != null){
                    stack.Push(node.right);
                }
                if(node.left != null){
                    stack.Push(node.left);
                }
            }
            return output;   
        }
    }
        
    public IList<int> PreorderTraversal(TreeNode root) {
        return PreorderTraversalIterative(root);        
    }
}