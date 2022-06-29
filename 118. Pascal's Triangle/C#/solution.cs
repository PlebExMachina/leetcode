public class Solution {
    public IList<IList<int>> Generate(int numRows) {
        // Fun C# thing, you can't implement nested interfaces 
        // so you need the inner type to be polymorphic. 
        var triangle = new IList<int>[numRows];
        triangle[0] = new int[] {1} ;
        
        // For each row...
        for(int i = 1; i < numRows; ++i){
            var row = new int[i+1];
            // First element is always 1.
            row[0] = 1;
            
            // Middle elements are composed of two elements in previous row.
            for(int j = 1; j < i; j++){
                row[j] = triangle[i-1][j-1] + triangle[i-1][j];
            }
            
            // Last element is always 1.
            row[i] = 1;
            triangle[i] = row;
        }
        return triangle;
    }
}