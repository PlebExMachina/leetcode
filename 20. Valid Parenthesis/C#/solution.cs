public class Solution {
    // Mapping of right parenthesis to left parenthesis.
    private static char getLeftParenthesis(char rp){
        switch(rp){
            case ')': return '(';
            case ']': return '[';
            case '}': return '{';
        }
        // Shouldn't execute gien constraints
        return '\0';
    }
    public bool IsValid(string s) {
        // Uses FIFO to enforce order of pairs.
        var leftParenthesisStack = new Stack<char>();
        // Push in left parenthesis, Pop them out if it's a right parenthesis.
        foreach(var c in s){
            bool isLeftParenthesis = (c== '{') || (c== '[') || (c=='(');
            if(isLeftParenthesis){
                leftParenthesisStack.Push(c);
            } else {
            // If bad, then short-circuit false
                if(
                    leftParenthesisStack.Count == 0 ||
                    (leftParenthesisStack.Pop() != getLeftParenthesis(c))
                ){
                    return false;
                }
            }
        }
        // Otherwise assert that all pairs have been found.
        return leftParenthesisStack.Count == 0;
    }
};