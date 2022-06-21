public class MinStack {
    // Contains a stack of elements.
    List<int> Arr;
    
    // Contains a stack of minimum elements.
    List<int> Minimum;

    // (Helper Function) Gets last element of List.
    private static int Last(List<int> i){
        return i[i.Count - 1];
    }
    
    // (Helper Function) Removes last element of List.
    private static void RemoveLast(List<int> i){
        i.RemoveAt(i.Count - 1);
    }
    
    public MinStack() {
        Arr = new List<int>();
        Minimum = new List<int>();
    }
    
    // By pushing minimum elements so that we only have descending elements
    // we ensure that the minimum element is always on top.
    // "Jagged Elements" within the original stack will always be popped before
    //  affecting the minimum element. 
    public void Push(int val) {
        Arr.Add(val);
        if (Minimum.Count == 0 || val <= Last(Minimum)) {
            Minimum.Add(val);
        }
    }
    
    // See documentation above for explanation.
    public void Pop() {
        if(Last(Arr) == Last(Minimum)){
            RemoveLast(Minimum);
        }
        RemoveLast(Arr);
    }
    
    public int Top() {
        return Last(Arr);
    }
    
    
    public int GetMin() {
        return Last(Minimum);
    }
}

/**
 * Your MinStack object will be instantiated and called as such:
 * MinStack obj = new MinStack();
 * obj.Push(val);
 * obj.Pop();
 * int param_3 = obj.Top();
 * int param_4 = obj.GetMin();
 */