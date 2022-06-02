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
    public bool IsSameTree(TreeNode p, TreeNode q) {        
        // Create stacks for iterative descent and push each respective root.
        var pStack = new Stack<TreeNode>(); 
        pStack.Push(p);
        var qStack = new Stack<TreeNode>(); 
        qStack.Push(q);
        
        /*
            Iterative Tree Descent
        */
        while(pStack.Count > 0){
            // Pop current context
            TreeNode pNode; bool pPopped = pStack.TryPop(out pNode); 
            TreeNode qNode; bool qPopped = qStack.TryPop(out qNode);
            
            // This might not be needed but I wont rule out error states.
            // In practice identical trees should have identical error states.
            if(pPopped != qPopped){
                return false;
            }
            
            // From current context nullness / values should be identical.
            if((qNode != null) && (pNode != null)){
                if(qNode.val != pNode.val){
                    return false;
                }
                
                // Push new contexts left and then right for each tree.
                pStack.Push(pNode.left);
                pStack.Push(pNode.right);
                qStack.Push(qNode.left);
                qStack.Push(qNode.right);
            } else if ((qNode == null && pNode != null) || (qNode != null && pNode == null)) {
                return false;
            }
        }
        // If no problems were encountered then they should be identical trees.
        return true;
    }
}